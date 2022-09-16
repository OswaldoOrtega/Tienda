CREATE DATABASE tiendagit;
USE tiendagit;
CREATE TABLE producto(
idproducto INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(100),
descripcion VARCHAR(100),
precio DOUBLE)

delimiter ;;
CREATE PROCEDURE insertartienda(
IN _nombre VARCHAR(100),
IN _descripcion VARCHAR(100),
IN _precio DOUBLE,
IN _idproducto INT)
BEGIN 
DECLARE x INT;
SELECT COUNT(*) FROM producto WHERE idproducto = _idproducto INTO x;
if x=0 AND _idproducto < 0 then
INSERT INTO producto VALUES(NULL,_nombre,_descripcion,_precio);
ELSE if x=0 AND _idproducto > 0 then
UPDATE producto SET nombre = _nombre, descripcion = _descripcion, precio = _precio WHERE idproducto = _idproducto;
ELSE 
UPDATE producto SET nombre = _nombre,descripcion = _descripcion, precio = _precio WHERE idproducto = _idproducto;
END if;
END if;
END;;

delimiter ;;
CREATE PROCEDURE deletetienda(
IN _idproducto INT)
BEGIN 
DELETE FROM producto WHERE idproducto = _idproducto;
END;;

delimiter ;;
CREATE PROCEDURE showtienda(
IN _filtro VARCHAR(100))
BEGIN 
SELECT p.nombre,p.descripcion,p.precio FROM producto p WHERE p.nombre LIKE _filtro;
END;;
