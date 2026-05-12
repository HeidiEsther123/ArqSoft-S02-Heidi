### Universidad: Tecnologico de Software
### Materia: Arquitectura de Software
### Maestro: Jorge Javier Pedroza Romero
### Alumno: Heidi Esther Peña Betanzos
### Grado: 3B
# Ahorcado
test del profe
## 🛠️ Refactorización SOLID
## identificar violaciones SOLID en Juego
| Situación | Principio Violado | Explicación |
| :--- | :--- | :--- |
| `Juego` maneja turnos, dibujo de tablero y mensajes. | **SRP** (Responsabilidad Única) | Mezcla lógica, presentación y datos. Cada rol debe ir en una clase distinta. |
| Palabras *hardcoded* en el constructor. | **DIP** (Inversión de Dependencias) | Depende de una lista fija. Debe usar una interfaz (ej. `IRepositorioPalabras`) para ser flexible. |
| Modificar `Juego` directamente para añadir variantes. | **OCP** (Abierto/Cerrado) | La clase no permite extensión sin alterar el código original. |