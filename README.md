# Proyecto de Gestión de Mascotas - BiblioMascota y App_Mascota

Este proyecto consta de dos componentes principales: una biblioteca de clases llamada "BiblioMascota" y una aplicación de interfaz de usuario llamada "App_Mascota". La biblioteca de clases se encarga de definir la clase `Mascota` y proporciona métodos para gestionar mascotas, mientras que la aplicación de interfaz de usuario permite administrar la información de las mascotas, incluyendo agregar, buscar, modificar y eliminar mascotas.

## Biblioteca de Clases - BiblioMascota

La biblioteca de clases "BiblioMascota" define la clase `Mascota` con los siguientes atributos y métodos:

- Atributos de la clase `Mascota`:
  - Id (número entero)
  - Nombre
  - Sexo (enumeración: Macho/Hembra)
  - Raza
  - Vacunas al día (booleano: true - al día, false - atrasadas)
  - Fecha de nacimiento (no puede ser menor a 1900-01-01)
  - Tamaño (Pequeño/Mediano/Grande)
  - Nombre del propietario
  - Edad del propietario

- Métodos de la clase `Mascota`:
  - `int ValorLavadoCortePelo()`: Retorna el precio de lavado/corte para las mascotas según su tamaño.
  - `Validar()`: Valida todos los datos obligatorios y las reglas de negocio, incluyendo tamaño y sexo.

## Aplicación de Interfaz de Usuario - App_Mascota

La aplicación "App_Mascota" es una interfaz de usuario que permite administrar la información de las mascotas. Aquí están las funcionalidades de la aplicación:

- Agregar mascotas: Se pueden ingresar datos como nombre, sexo, raza, estado de vacunas, fecha de nacimiento, tamaño, nombre del propietario y edad del propietario.

- Buscar mascotas por ID: Al ingresar un ID de mascota y presionar el botón "Buscar ID", se mostrarán los datos de la mascota en el formulario, incluyendo el valor del servicio de lavado/corte de pelo.

- Modificar mascotas: Se pueden modificar los datos de una mascota existente y se reflejarán los cambios en la grilla.

- Eliminar mascotas: Al presionar el botón "Eliminar", se mostrará una ventana modal para confirmar la eliminación de la mascota seleccionada.

- Listar todas las mascotas: La aplicación muestra una grilla con todas las mascotas registradas.

- Validación: La aplicación utiliza el método `Validar()` de la clase `Mascota` para asegurarse de que los datos ingresados sean válidos.

- Datos de prueba: La aplicación cuenta con al menos 5 mascotas como datos de prueba.

## VISTA

- ![Vista](https://github.com/ClaudioVergara2/CanDog/blob/main/Prototipo.jpg)

