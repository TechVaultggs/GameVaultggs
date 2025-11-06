-- Eliminar tablas si ya existen para permitir una recreación limpia
DROP TABLE IF EXISTS Persona;
DROP TABLE IF EXISTS Institucion;

-- Crear la tabla Institucion
CREATE TABLE Institucion (
    nombre VARCHAR(255) NOT NULL,
    sigla VARCHAR(50) PRIMARY KEY,
    pais VARCHAR(100),
    especialidad VARCHAR(100),
    web VARCHAR(255)
);

-- Crear la tabla Persona
CREATE TABLE Persona (
    id SERIAL PRIMARY KEY,
    nombres VARCHAR(255) NOT NULL,
    telefono VARCHAR(20),
    ciudad VARCHAR(100),
    agencia VARCHAR(50) REFERENCES Institucion(sigla),
    categoria VARCHAR(50) CHECK (categoria IN ('Auxiliar', 'Profesional', 'Funcionario')),
    salario NUMERIC(10, 2)
);

-- Insertar datos de ejemplo en la tabla Institucion
INSERT INTO Institucion (nombre, sigla, pais, especialidad, web) VALUES
('Universidad Nacional de Ciencia', 'UNC', 'Chile', 'Ciencias de la Computación', 'http://unc.cl'),
('Centro de Investigación Avanzada', 'CIA', 'Argentina', 'Biología', 'http://cia.ar'),
('Instituto Tecnológico del Sur', 'ITS', 'Colombia', 'Ingeniería', 'http://its.co'),
('Sociedad de Física Aplicada', 'SFA', 'Chile', 'Física', 'http://sfa.cl'),
('Organización Mundial de Salud', 'OMS', 'Suiza', 'Salud', 'http://who.int');

-- Insertar datos de ejemplo en la tabla Persona
INSERT INTO Persona (nombres, telefono, ciudad, agencia, categoria, salario) VALUES
('Juan Perez', '12345678', 'Santiago', 'UNC', 'Profesional', 50000.00),
('Maria Rodriguez', '87654321', 'Buenos Aires', 'CIA', 'Funcionario', 60000.00),
('Carlos Gomez', '11223344', 'Bogotá', 'ITS', 'Profesional', 55000.00),
('Ana Torres', '44332211', 'Santiago', 'SFA', 'Auxiliar', 25000.00),
('Luis Hernandez', '55667788', 'Ginebra', 'OMS', 'Funcionario', 75000.00),
('Sofia Castro', '99887766', 'Santiago', 'UNC', 'Auxiliar', 28000.00),
('Andres Morales', '66778899', 'Buenos Aires', 'CIA', 'Profesional', 52000.00),
('Laura Jimenez', '33445566', 'Bogotá', 'ITS', 'Auxiliar', 26000.00);
