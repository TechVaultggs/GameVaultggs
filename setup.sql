-- Asegurarse de que las tablas no existan para evitar errores en ejecuciones repetidas
DROP TABLE IF EXISTS Operacion;
DROP TABLE IF EXISTS Empleado;
DROP TABLE IF EXISTS Vehiculo;

-- Crear tabla Empleado
CREATE TABLE Empleado (
    cod_empleado INT PRIMARY KEY,
    nom_empleado VARCHAR(100),
    telefono VARCHAR(20),
    ciudad VARCHAR(50)
);

-- Crear tabla Vehiculo
CREATE TABLE Vehiculo (
    vehiculo VARCHAR(50) PRIMARY KEY,
    tipo VARCHAR(50)
);

-- Crear tabla Operacion
CREATE TABLE Operacion (
    cod_operacion INT PRIMARY KEY IDENTITY(1,1),
    cod_empleado INT,
    vehiculo VARCHAR(50),
    mes INT,
    ano INT,
    monto DECIMAL(18, 2),
    FOREIGN KEY (cod_empleado) REFERENCES Empleado(cod_empleado),
    FOREIGN KEY (vehiculo) REFERENCES Vehiculo(vehiculo)
);

-- Insertar datos de muestra en Empleado
INSERT INTO Empleado (cod_empleado, nom_empleado, telefono, ciudad) VALUES
(1, 'Juan Perez', '123-456-7890', 'Madrid'),
(2, 'Ana Gomez', '098-765-4321', 'Barcelona'),
(3, 'Luis Rodriguez', '555-555-5555', 'Madrid');

-- Insertar datos de muestra en Vehiculo
INSERT INTO Vehiculo (vehiculo, tipo) VALUES
('Toyota Camry', 'Sedan'),
('Honda CR-V', 'SUV'),
('Ford F-150', 'Camioneta');

-- Insertar datos de muestra en Operacion
INSERT INTO Operacion (cod_empleado, vehiculo, mes, ano, monto) VALUES
(1, 'Toyota Camry', 1, 2023, 15000.00),
(1, 'Honda CR-V', 1, 2023, 25000.00),
(2, 'Toyota Camry', 1, 2023, 16000.00),
(2, 'Ford F-150', 2, 2023, 35000.00),
(3, 'Honda CR-V', 2, 2023, 26000.00),
(1, 'Toyota Camry', 3, 2023, 15500.00);
