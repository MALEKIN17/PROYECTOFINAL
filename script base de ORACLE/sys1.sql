
CREATE TABLESPACE proyecto DATAFILE 'C:\app\santa\product\18.0.0\oradata\XE\XEPDB1\proyecto.dbf' SIZE 20M;

alter session set "_ORACLE_SCRIPT"=true;

CREATE USER propietario2 IDENTIFIED BY oracle DEFAULT TABLESPACE proyecto TEMPORARY TABLESPACE TEMP QUOTA UNLIMITED ON proyecto;

CREATE ROLE ADMINISTRADOR2;




GRANT CREATE SESSION,CREATE PROCEDURE,CREATE VIEW,SELECT ANY TABLE,CREATE ANY TABLE, CREATE TRIGGER,CREATE SYNONYM,
CREATE SEQUENCE TO ADMINISTRADOR2;

GRANT ADMINISTRADOR2 TO propietario2;



