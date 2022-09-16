CREATE DATABASE tiendagit;
USE tiendagit;
CREATE TABLE producto(
idproducto INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(100),
descripcion VARCHAR(100),
precio DOUBLE)

SELECT * FROM producto;