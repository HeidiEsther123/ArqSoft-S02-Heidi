### Universidad: Tecnologico de Software
### Materia: Arquitectura de Software
### Maestro: Jorge Javier Pedroza Romero
### Alumno: Heidi Esther Peña Betanzos
### Grado: 3B
# 🪢 Ahorcado 🪢

## 👀 Descripción del proyecto 👀
Este proyecto implementa el clásico juego del **Ahorcado** en consola.  
Se trabajó primero con una versión inicial (clase dios) y luego se aplicó **refactorización SOLID** para separar responsabilidades, reducir acoplamiento y permitir extensiones como pistas y categorías de palabras.

---
## 🪄 Tecnologías utilizadas 🪄
- Lenguaje: **C#**
- Framework: **.NET 6.0**
- IDE: **Visual Studio**
- Principios de diseño: **SOLID**
  
---

## 🛠️ Refactorización SOLID 🛠️
## identificar violaciones SOLID en Juego.cs (la clase dios)
| Situación | Principio Violado | Explicación |
| :--- | :--- | :--- |
| `Juego` maneja turnos, dibujo de tablero y mensajes. | **SRP** (Responsabilidad Única) | Mezcla lógica, presentación y datos. Cada rol debe ir en una clase distinta. |
| Palabras *hardcoded* en el constructor. | **DIP** (Inversión de Dependencias) | Depende de una lista fija. Debe usar una interfaz (ej. `IRepositorioPalabras`) para ser flexible. |
| Modificar `Juego` directamente para añadir variantes. | **OCP** (Abierto/Cerrado) | La clase no permite extensión sin alterar el código original. |

---

## 📸 Capturas de pantalla 📸

### Pantalla principal del juego
<img width="1918" height="1078" alt="Captura de pantalla 2026-05-12 164045" src="https://github.com/user-attachments/assets/c9de0c34-c6f7-42af-9a56-c00a027aac4c" />


### Codigo de Juego (Clase Dios)
<img width="1266" height="1017" alt="Captura de pantalla 2026-05-12 164621" src="https://github.com/user-attachments/assets/88a5ac93-d057-4e5b-a4d5-197981096008" />


### Codigo de ConsolaUI
<img width="1265" height="1020" alt="Captura de pantalla 2026-05-12 165815" src="https://github.com/user-attachments/assets/218e71b1-4245-4a11-b7fc-703f4c3c7047" />

---

### Cláusula

Yo Heidi Esther Peña Betanzos si use AI para poder relalizar la tarea, use Copilot para organizar el codigo porporcionado para la actividad ya que mi portapaeles lo copiaba mal y arreglar un error de mi visual que me impedia ejecutar mi programa. 
