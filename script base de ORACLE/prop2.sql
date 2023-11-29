----------------------------------CREACION DE TABLAS-----------------------------------------------

CREATE TABLE Cuentas (usuario varchar2(15), contraseña varchar2(15));

CREATE TABLE Propietarios (cedulapropietario varchar2(15), primernombre varchar2(15), primerapellido varchar2(15),
telefono varchar2(15),cargo varchar2(15),usuario varchar2(15));

CREATE TABLE Empleados (cedulaempleado varchar2(15), primernombre varchar2(15), primerapellido varchar2(15), 
telefono varchar2(15),cargo varchar2(15),usuario varchar2(15));

CREATE TABLE Clientes (cedulacliente varchar2(15),primernombre varchar2(15), primerapellido varchar2(15),
telefono varchar2(15));

CREATE TABLE Servicios (codigoservicio number,nombreservicio varchar2(30), precioservicio number);

CREATE TABLE Detalles (codigodetalle number,nombreservicio varchar2(30), precioservicio varchar2(30),
codfacturaservicio varchar2(30));

CREATE TABLE Facturas (numerofactura number, fecha date, cedulacliente varchar2(15), 
cedulaempleado varchar2(15),placa varchar2(10),preciototal number);

CREATE TABLE Vehiculos (marca varchar2(15), modelo varchar2(15), placa varchar2(15), 
cedulacliente varchar2(15));

----------------------------------DROPEO DE TABLAS PORSIACASO-----------------------------------------------

DROP TABLE Detalles;
DROP TABLE Facturas;
DROP TABLE Propietarios;
DROP TABLE Empleados;
DROP TABLE Cuentas;
DROP TABLE Servicios;
DROP TABLE Vehiculos;
DROP TABLE Clientes;

----------------------------------CONSTRAINTS-----------------------------------------------
ALTER TABLE Cuentas
    ADD CONSTRAINT PK_Cuentas1 PRIMARY KEY (usuario);
/
ALTER TABLE Propietarios
ADD CONSTRAINT PK_Propietarios1 PRIMARY KEY (cedulapropietario);
/
ALTER TABLE Empleados
ADD CONSTRAINT PK_Empleados PRIMARY KEY (cedulaempleado);
/
ALTER TABLE Clientes
ADD CONSTRAINT PK_Clientes PRIMARY KEY (cedulacliente);
/
ALTER TABLE Servicios
ADD CONSTRAINT PK_Servicios PRIMARY KEY (codigoservicio);
/
ALTER TABLE Vehiculos
ADD CONSTRAINT PK_Vehiculos PRIMARY KEY (placa);
/
ALTER TABLE Facturas
ADD CONSTRAINT PK_Facturas PRIMARY KEY (numerofactura);
/
ALTER TABLE Detalles
ADD CONSTRAINT PK_Detalles PRIMARY KEY (codigodetalle);

----------------------------------SECUENCIAS-----------------------------------------------
CREATE SEQUENCE SQ_ID_SERVICIOS
START WITH 1
INCREMENT BY 1;
/  
CREATE SEQUENCE SQ_ID_DETALLES
START WITH 1
INCREMENT BY 1;
/   
CREATE SEQUENCE SQ_ID_FACTURAS
START WITH 1
INCREMENT BY 1;
/
CREATE SEQUENCE SQ_ID_DETALLE
START WITH 1
INCREMENT BY 1;

----------------------------------DISPARADORES-----------------------------------------------

CREATE OR REPLACE NONEDITIONABLE TRIGGER TG_GENERAR_PK_SERVICIOS
BEFORE INSERT ON Servicios
FOR EACH ROW
BEGIN
SELECT SQ_ID_SERVICIOS.NEXTVAL INTO :NEW.codigoservicio FROM dual;
END;

/
CREATE OR REPLACE NONEDITIONABLE TRIGGER TG_GENERAR_PK_DETALLES
BEFORE INSERT ON Detalles
FOR EACH ROW
BEGIN
SELECT SQ_ID_DETALLES.NEXTVAL INTO :NEW.codigodetalle FROM dual;
END;

/
CREATE OR REPLACE NONEDITIONABLE TRIGGER TG_GENERAR_PK_FACTURAS
BEFORE INSERT ON Facturas
FOR EACH ROW
BEGIN
SELECT SQ_ID_FACTURAS.NEXTVAL INTO :NEW.numerofactura FROM dual;
END;

----------------------------------Vistas-----------------------------------------------
CREATE OR REPLACE VIEW vista_usuarios AS
SELECT c.usuario, c.contraseña, p.cedulapropietario AS cedula, 'Administrador' AS tipo_de_cuenta
FROM cuentas c
INNER JOIN propietarios p ON c.usuario = p.usuario
UNION ALL
SELECT c.usuario, c.contraseña, e.cedulaempleado AS cedula, 'Empleado' AS tipo_de_cuenta
FROM cuentas c
INNER JOIN empleados e ON c.usuario = e.usuario;

CREATE OR REPLACE VIEW vistafacturas AS
SELECT c.cedulacliente, f.cedulacliente AS cedula
FROM clientes c
INNER JOIN facturas f ON c.cedulacliente = f.cedulacliente
UNION ALL
SELECT e.cedulaempleado, f.cedulaempleado AS cedula
FROM empleados e
INNER JOIN facturas f ON e.cedulaempleado = f.cedulaempleado;

CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "PROPIETARIO2"."V_NOMBRES_CEDULAS" ("CEDULA", "NOMBRE", "APELLIDO","TELEFONO","USUARIO","CARGO") AS 
SELECT cedulaempleado AS cedula, primernombre AS nombre, primerapellido AS apellido,telefono AS telefono, 
usuario AS usuario,cargo AS cargo
FROM empleados
UNION ALL
SELECT cedulapropietario AS cedula, primernombre AS nombre, primerapellido AS apellido,telefono AS telefono, usuario AS usuario,cargo AS cargo 
FROM propietarios;

CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "PROPIETARIO2"."V_NOMBRES_PERSONAS" ("CEDULA", "NOMBRE", "APELLIDO","TELEFONO") AS 
SELECT cedulaempleado AS cedula, primernombre AS nombre, primerapellido AS apellido,telefono AS telefono
FROM empleados
UNION ALL
SELECT cedulapropietario AS cedula, primernombre AS nombre, primerapellido AS apellido,telefono AS telefono
FROM propietarios
UNION ALL
SELECT cedulacliente AS cedula, primernombre AS nombre, primerapellido AS apellido,telefono AS telefono
FROM clientes;


CREATE OR REPLACE FORCE NONEDITIONABLE VIEW "PROPIETARIO2"."V_FACTURAS" ("CEDULA", "NOMBRE", "APELLIDO","TELEFONO") AS 
SELECT cedulaempleado AS cedula, primernombre AS nombre, primerapellido AS apellido,telefono AS telefono
FROM empleados
UNION ALL
SELECT cedulapropietario AS cedula, primernombre AS nombre, primerapellido AS apellido,telefono AS telefono 
FROM clientes;




----------------------------------PAQUETES Y BODYS-----------------------------------------------
----------------------------------CUENTAS-----------------------------------------------

--CABESA
 CREATE OR REPLACE NONEDITIONABLE PACKAGE FNS_CUENTAS IS
    FUNCTION InsertarCuenta(usuario varchar2, contraseña varchar2) 
    RETURN VARCHAR2; 
    FUNCTION EliminarCuenta(p_usuario VARCHAR2) RETURN VARCHAR2;
 END FNS_CUENTAS;
--CUERPO
CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY FNS_CUENTAS IS
FUNCTION InsertarCuenta (usuario varchar2, contraseña varchar2) 
RETURN VARCHAR2
IS
BEGIN
INSERT INTO cuentas (usuario,contraseña)
VALUES (usuario,contraseña);
COMMIT;
RETURN 'OK';
EXCEPTION
WHEN OTHERS THEN
ROLLBACK;
RETURN 'Error al guardar cuenta: ' || SQLERRM;
END InsertarCuenta;

FUNCTION EliminarCuenta(p_usuario VARCHAR2) RETURN VARCHAR2 IS
  BEGIN
    DELETE FROM cuentas 
    WHERE usuario = p_usuario;
    COMMIT;
    RETURN 'OK';
  EXCEPTION
    WHEN OTHERS THEN
      ROLLBACK;
      RAISE_APPLICATION_ERROR(-20002, 'Error al eliminar cuenta: ' || SQLERRM);
  END EliminarCuenta;
end FNS_CUENTAS;
----------------------------------CLIENTES-----------------------------------------------
--CABESA
CREATE OR REPLACE NONEDITIONABLE PACKAGE FNS_CLIENTES IS
    FUNCTION InsertarCliente(cedulacliente IN VARCHAR2,primernombre IN VARCHAR2,primerapellido IN VARCHAR2,telefono IN VARCHAR2) 
    RETURN VARCHAR2;
    
    FUNCTION EliminarCliente(p_cedula IN VARCHAR2) RETURN VARCHAR2;
    
    FUNCTION ActualizarCliente(p_cl_cedula VARCHAR2,p_pr_nombre VARCHAR2,p_pr_apellido VARCHAR2,P_telefono VARCHAR2) RETURN VARCHAR2;
END FNS_CLIENTES;
--CUERPO
create or replace NONEDITIONABLE PACKAGE BODY FNS_CLIENTES IS
FUNCTION InsertarCliente (cedulacliente IN VARCHAR2,primernombre IN VARCHAR2,primerapellido IN VARCHAR2,telefono IN VARCHAR2) 
RETURN VARCHAR2
IS
BEGIN
INSERT INTO clientes (cedulacliente, primernombre, primerapellido,telefono)
VALUES (cedulacliente, primernombre, primerapellido,telefono);
COMMIT;
RETURN 'OK';
EXCEPTION
WHEN OTHERS THEN
ROLLBACK;
RETURN 'Error al guardar cliente: ' || SQLERRM;
END InsertarCliente;

FUNCTION EliminarCliente(p_cedula IN VARCHAR2) 
  RETURN VARCHAR2 
IS
BEGIN
DELETE FROM clientes WHERE cedulacliente = p_cedula;
COMMIT;
RETURN 'Empleado eliminado correctamente';
EXCEPTION
WHEN OTHERS THEN
ROLLBACK;
RETURN 'Error al eliminar empleado: ' || SQLERRM;
END EliminarCliente;


FUNCTION actualizarCliente(p_cl_cedula VARCHAR2,p_pr_nombre VARCHAR2,p_pr_apellido VARCHAR2,P_telefono VARCHAR2) 
RETURN VARCHAR2 IS
BEGIN
  -- Actualizar los atributos del vehículo
UPDATE clientes
SET primernombre = p_pr_nombre,primerapellido = p_pr_apellido,telefono = p_telefono
WHERE cedulacliente = p_cl_cedula;
COMMIT;
RETURN 'OK';
EXCEPTION
WHEN OTHERS THEN
ROLLBACK;
RETURN 'Error al actualizar cliente: ' || SQLERRM;
END actualizarCliente;
END FNS_CLIENTES;

----------------------------------EMPLEADOS-----------------------------------------------
--CABESA
CREATE OR REPLACE NONEDITIONABLE PACKAGE FNS_EMPLEADOS IS
    FUNCTION InsertarEmpleado(cedulaempleado IN VARCHAR2,primernombre IN VARCHAR2,primerapellido IN VARCHAR2,telefono IN VARCHAR2,
    cargo IN VARCHAR2,usuario IN VARCHAR2) RETURN VARCHAR2;
    
    FUNCTION EliminarEmpleado(P_emp_cedula IN VARCHAR2) RETURN VARCHAR2;
    
    FUNCTION ActualizarEmpleado(p_emp_cedula VARCHAR2,p_pr_nombre VARCHAR2,p_pr_apellido VARCHAR2,P_telefono VARCHAR2) RETURN VARCHAR2;
END FNS_EMPLEADOS;

--CUERPO

CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY FNS_EMPLEADOS IS
FUNCTION InsertarEmpleado(cedulaempleado IN VARCHAR2,primernombre IN VARCHAR2,primerapellido IN VARCHAR2,telefono IN VARCHAR2,cargo IN VARCHAR2,
usuario IN VARCHAR2) RETURN VARCHAR2
IS
BEGIN
INSERT INTO empleados (cedulaempleado, primernombre, primerapellido,telefono,cargo,usuario)
VALUES (cedulaempleado, primernombre, primerapellido,telefono,cargo,usuario);
COMMIT;
RETURN 'OK';
EXCEPTION
WHEN OTHERS THEN
ROLLBACK;
RAISE_APPLICATION_ERROR(-20001, 'Error al guardar empleado: ' || SQLERRM);
END InsertarEmpleado;

FUNCTION EliminarEmpleado(P_emp_cedula IN VARCHAR2) 
  RETURN VARCHAR2 
IS
BEGIN
  -- Eliminar empleado
  DELETE FROM empleados WHERE cedulaempleado = P_emp_cedula;

  COMMIT;
  RETURN 'Empleado eliminado correctamente';
EXCEPTION
  WHEN OTHERS THEN
    ROLLBACK;
    RETURN 'Error al eliminar empleado: ' || SQLERRM;
END EliminarEmpleado;


FUNCTION ActualizarEmpleado(p_emp_cedula VARCHAR2,p_pr_nombre VARCHAR2,p_pr_apellido VARCHAR2,P_telefono VARCHAR2)
RETURN VARCHAR2 IS
BEGIN
  -- Actualizar los atributos del vehículo
UPDATE empleados
SET primernombre = p_pr_nombre,primerapellido = p_pr_apellido,telefono = p_telefono
WHERE cedulaempleado = p_emp_cedula;
COMMIT;
RETURN 'OK';
EXCEPTION
WHEN OTHERS THEN
ROLLBACK;
RETURN 'Error al actualizar empleado: ' || SQLERRM;
END actualizarEmpleado;
END FNS_EMPLEADOS;

----------------------------------PROPIETARIOS-----------------------------------------------
--CABESA
CREATE OR REPLACE NONEDITIONABLE PACKAGE FNS_PROPIETARIOS IS
 	FUNCTION InsertarPropietario (cedulapropietario varchar2,primernombre varchar2, primerapellido varchar2, 
    telefono varchar2,cargo varchar2, usuario varchar2) RETURN VARCHAR2;
    
    FUNCTION EliminarPropietario(Adm_cedula IN VARCHAR2) RETURN VARCHAR2 ;
    
    FUNCTION ActualizarPropietario(p_prop_cedula VARCHAR2,p_pr_nombre VARCHAR2,p_pr_apellido VARCHAR2,P_telefono VARCHAR2) RETURN VARCHAR2;
    
END FNS_PROPIETARIOS;
--CUERPO
CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY FNS_PROPIETARIOS IS
 	FUNCTION InsertarPropietario (cedulapropietario varchar2,primernombre varchar2, primerapellido varchar2, 
    telefono varchar2,cargo varchar2, usuario varchar2)RETURN VARCHAR2
IS
BEGIN
    INSERT INTO Propietarios (cedulapropietario, primernombre, primerapellido, telefono,cargo, usuario) 
    VALUES (cedulapropietario, primernombre, primerapellido, telefono,cargo, usuario); 
    COMMIT;
    RETURN 'OK';
EXCEPTION
    WHEN OTHERS THEN
    ROLLBACK;
        RETURN 'Error al guardar administrador: ' || SQLERRM;
END InsertarPropietario;

FUNCTION EliminarPropietario(Adm_cedula IN VARCHAR2) 
RETURN VARCHAR2 
IS
BEGIN
  DELETE FROM Propietarios WHERE cedulapropietario = Adm_cedula;
  COMMIT;
  RETURN 'Administrador eliminado correctamente';
EXCEPTION
  WHEN OTHERS THEN
    ROLLBACK;
    RETURN 'Error al eliminar administrador: ' || SQLERRM;
END EliminarPropietario;

FUNCTION ActualizarPropietario(p_prop_cedula VARCHAR2,p_pr_nombre VARCHAR2,p_pr_apellido VARCHAR2,P_telefono VARCHAR2)
RETURN VARCHAR2 IS
BEGIN
  -- Actualizar los atributos del vehículo
UPDATE propietarios
SET primernombre = p_pr_nombre,primerapellido = p_pr_apellido,telefono = p_telefono
WHERE cedulapropietario = p_prop_cedula;
COMMIT;
RETURN 'OK';
EXCEPTION
WHEN OTHERS THEN
ROLLBACK;
RETURN 'Error al actualizar administrador: ' || SQLERRM;
END actualizarPropietario;
END FNS_PROPIETARIOS;

----------------------------------SERVICIOS-----------------------------------------------
--CABESA
CREATE OR REPLACE NONEDITIONABLE PACKAGE FNS_SERVICIOS IS
 	FUNCTION InsertarServicio (nombreservicio varchar2, precioservicio number) RETURN VARCHAR2;
    
    FUNCTION EliminarServicio(p_cod_servicio number) RETURN VARCHAR2 ;
    
    FUNCTION ActualizarServicio(p_codigoservicio number,p_nombreservicio varchar2, p_precioservicio number) RETURN VARCHAR2;
    
END FNS_SERVICIOS;
--CUERPO

CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY FNS_SERVICIOS IS
 	FUNCTION InsertarServicio (nombreservicio varchar2, precioservicio number)RETURN VARCHAR2
IS
BEGIN
    INSERT INTO servicios (nombreservicio, precioservicio) 
    VALUES (nombreservicio, precioservicio); 
    COMMIT;
    RETURN 'OK';
EXCEPTION
    WHEN OTHERS THEN
    ROLLBACK;
        RETURN 'Error al guardar servicio: ' || SQLERRM;
END InsertarServicio;

FUNCTION EliminarServicio(p_cod_servicio number) 
RETURN VARCHAR2 
IS
BEGIN
  DELETE FROM servicios WHERE codigoservicio = p_cod_servicio;
  COMMIT;
  RETURN 'servicio eliminado correctamente';
EXCEPTION
  WHEN OTHERS THEN
    ROLLBACK;
    RETURN 'Error al eliminar servicio: ' || SQLERRM;
END EliminarServicio;

FUNCTION ActualizarServicio(p_codigoservicio number,p_nombreservicio varchar2, p_precioservicio number)
RETURN VARCHAR2 IS
BEGIN
  -- Actualizar los atributos del vehículo
UPDATE servicios
SET nombreservicio = p_nombreservicio,precioservicio = p_precioservicio
WHERE codigoservicio = p_codigoservicio;
COMMIT;
RETURN 'OK';
EXCEPTION
WHEN OTHERS THEN
ROLLBACK;
RETURN 'Error al actualizar empleado: ' || SQLERRM;
END actualizarServicio;
END FNS_SERVICIOS;
----------------------------------DETALLES-----------------------------------------------
--CABESA
CREATE OR REPLACE NONEDITIONABLE PACKAGE FNS_DETALLES IS
 	FUNCTION InsertarDetalle (nombreservicio varchar2, precioservicio varchar2,codfacturaservicio varchar2) RETURN VARCHAR2;
    
    FUNCTION EliminarDetalle(p_cod_factura number) RETURN VARCHAR2 ;
END FNS_DETALLES;
--CUERPO

CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY FNS_DETALLES IS
 	FUNCTION InsertarDetalle (nombreservicio varchar2, precioservicio varchar2,codfacturaservicio varchar2)RETURN VARCHAR2
IS
BEGIN
    INSERT INTO detalles (nombreservicio, precioservicio,codfacturaservicio) 
    VALUES (nombreservicio, precioservicio,codfacturaservicio); 
    COMMIT;
    RETURN 'OK';
EXCEPTION
    WHEN OTHERS THEN
    ROLLBACK;
        RETURN 'Error al guardar detalle: ' || SQLERRM;
END InsertarDetalle;

FUNCTION EliminarDetalle(p_cod_factura number) 
RETURN VARCHAR2 
IS
BEGIN
  DELETE FROM detalles WHERE codfacturaservicio = p_cod_factura;
  COMMIT;
  RETURN 'detalle eliminado correctamente';
EXCEPTION
  WHEN OTHERS THEN
    ROLLBACK;
    RETURN 'Error al eliminar detalle: ' || SQLERRM;
END EliminarDetalle;
END FNS_DETALLES;
----------------------------------FACRURAS-----------------------------------------------
--CABESA
CREATE OR REPLACE NONEDITIONABLE PACKAGE FNS_FACTURAS IS

 	FUNCTION InsertarFactura (fecha date,cedulacliente varchar2,cedulaempleado varchar2,placa varchar2,preciototal number) RETURN VARCHAR2;
    
    FUNCTION EliminarFactura(factura_id number) RETURN VARCHAR2 ;
    
    FUNCTION ActualizarFactura(p_numerofactura number,p_cedulacliente varchar2,p_cedulaempleado varchar2,p_placa varchar2) RETURN VARCHAR2;
    
END FNS_FACTURAS;
--CUERPO

CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY FNS_FACTURAS IS
FUNCTION InsertarFactura (fecha date,cedulacliente varchar2,cedulaempleado varchar2,placa varchar2,preciototal number)RETURN VARCHAR2
IS
BEGIN
    INSERT INTO Facturas (fecha,cedulacliente,cedulaempleado,placa,preciototal) 
    VALUES (fecha,cedulacliente,cedulaempleado,placa,preciototal); 
    COMMIT;
    RETURN 'OK';
EXCEPTION
    WHEN OTHERS THEN
    ROLLBACK;
        RETURN 'Error al guardar factura: ' || SQLERRM;
END InsertarFactura;

FUNCTION EliminarFactura(factura_id number) 
RETURN VARCHAR2 
IS
BEGIN
  DELETE FROM Facturas WHERE numerofactura = factura_id;
  COMMIT;
  RETURN 'factura eliminado correctamente';
EXCEPTION
  WHEN OTHERS THEN
    ROLLBACK;
    RETURN 'Error al eliminar factura: ' || SQLERRM;
END EliminarFactura;

FUNCTION ActualizarFactura(p_numerofactura number,p_cedulacliente varchar2,p_cedulaempleado varchar2,p_placa varchar2)
RETURN VARCHAR2 IS
BEGIN
  -- Actualizar los atributos del vehículo
UPDATE Facturas
SET cedulacliente = p_cedulacliente,cedulaempleado = p_cedulaempleado,placa = p_placa
WHERE numerofactura = p_numerofactura;
COMMIT;
RETURN 'OK';
EXCEPTION
WHEN OTHERS THEN
ROLLBACK;
RETURN 'Error al actualizar factura: ' || SQLERRM;
END ActualizarFactura;
END FNS_FACTURAS;
----------------------------------VEHICULOS-----------------------------------------------
--CABESA
CREATE OR REPLACE NONEDITIONABLE PACKAGE FNS_VEHICULOS IS

 	FUNCTION InsertarVehiculo (marca varchar2, modelo varchar2, placa varchar2, 
    cedulacliente varchar2) RETURN VARCHAR2;
    
    FUNCTION EliminarVehiculos(p_cliente_id varchar2) RETURN VARCHAR2 ;
    
    FUNCTION EliminarVehiculo(p_placa varchar2) RETURN VARCHAR2 ;
    
    FUNCTION ActualizarVehiculo(p_marca varchar2, p_modelo varchar2, p_placa varchar2, p_cedulacliente varchar2) RETURN VARCHAR2;
    
END FNS_VEHICULOS;

--CUERPO
CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY FNS_VEHICULOS IS
FUNCTION InsertarVehiculo (marca varchar2, modelo varchar2, placa varchar2, 
    cedulacliente varchar2)RETURN VARCHAR2
IS
BEGIN
    INSERT INTO Vehiculos (marca, modelo, placa, cedulacliente) 
    VALUES (marca, modelo, placa, cedulacliente); 
    COMMIT;
    RETURN 'OK';
EXCEPTION
    WHEN OTHERS THEN
    ROLLBACK;
        RETURN 'Error al guardar Vehiculo: ' || SQLERRM;
END InsertarVehiculo;

FUNCTION EliminarVehiculo(p_placa varchar2) 
RETURN VARCHAR2 
IS
BEGIN
  DELETE FROM Vehiculos WHERE placa = p_placa;
  COMMIT;
  RETURN 'Vehiculo eliminado correctamente';
EXCEPTION
  WHEN OTHERS THEN
    ROLLBACK;
    RETURN 'Error al eliminar Vehiculo: ' || SQLERRM;
END EliminarVehiculo;

FUNCTION EliminarVehiculos(p_cliente_id varchar2) 
RETURN VARCHAR2 
IS
BEGIN
  DELETE FROM Vehiculos WHERE cedulacliente = p_cliente_id;
  COMMIT;
  RETURN 'Vehiculos eliminados correctamente';
EXCEPTION
  WHEN OTHERS THEN
    ROLLBACK;
    RETURN 'Error al eliminar Vehiculo: ' || SQLERRM;
END EliminarVehiculos;

FUNCTION ActualizarVehiculo(p_marca varchar2, p_modelo varchar2, p_placa varchar2, p_cedulacliente varchar2)
RETURN VARCHAR2 IS
BEGIN
  -- Actualizar los atributos del vehículo
UPDATE Vehiculos
SET marca = p_marca,modelo = p_modelo,placa = p_placa,cedulacliente = p_cedulacliente
WHERE placa = p_placa;
COMMIT;
RETURN 'OK';
EXCEPTION
WHEN OTHERS THEN
ROLLBACK;
RETURN 'Error al actualizar Vehiculo: ' || SQLERRM;
END ActualizarVehiculo;
END FNS_VEHICULOS;

DELETE FROM cuentas
WHERE usuario = 'nombre_usuario';
