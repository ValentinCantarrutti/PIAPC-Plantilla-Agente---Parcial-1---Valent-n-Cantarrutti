# Auditoria del repositorio

## Objetivo

Registrar hechos verificables sobre la estructura, arquitectura y validacion del proyecto antes de proponer cambios.

## Rutas y simbolos relevantes

| Ruta o simbolo | Rol observado | Evidencia |
|---|---|---|
| README.md | Documentación base y metadatos del proyecto académico. | Archivo principal de la plantilla PIAPC, actualmente completado con la información definida para el proyecto. |
| GDD.md | Documento de diseño del juego. | Archivo de la plantilla con secciones de datos del proyecto, descripción, requisitos y ejecución, controles, créditos y entrega o demostración. |
| AGENTS.md | Normas de trabajo para agentes y estudiantes. | Archivo que establece reglas para explorar el repositorio, documentar el proceso y controlar las modificaciones. |
| .gitignore | Configuración de exclusiones de control de versiones. | Archivo presente en la plantilla con reglas para excluir archivos y carpetas generados o temporales. |
| docs/ | Documentación del proceso académico. | Carpeta que contiene `README.md`, donde se indica el orden de los documentos que deben completarse. |
| main | Rama principal del repositorio. | Contiene el estado inicial de la plantilla. |


## Flujo observado

No se pudo observar un flujo de ejecución del juego porque el repositorio actual no contiene una implementación de Unity verificable.

El flujo observable corresponde al proceso documental del proyecto: definición del GDD, especificación del problema, planificación de una intervención, revisión de permisos y registro de las intervenciones de OpenCode.

No se identificaron en el repositorio escenas .unity, scripts .cs ni una carpeta Assets/ que permitan describir un flujo de ejecución, entrada del jugador, movimiento o salto del personaje.

## Pruebas y comandos disponibles

| Comando o prueba | Que verifica | Resultado inicial |
|---|---|---|
| Revisión de la estructura y archivos del repositorio | Determinar qué archivos y elementos de implementación existen realmente. | No se encontró una implementación de Unity del juego en el repositorio actual. |
| Revisión de archivos .cs, escenas .unity y carpeta Assets/ | Comprobar si existen elementos de implementación que permitan analizar el sistema de salto. | No se encontraron esos elementos en el repositorio actual. |

No se registran comandos de ejecución del juego porque no existe actualmente una implementación verificable que permita ejecutar y validar el comportamiento del salto.

## Hechos, supuestos y preguntas abiertas

Hechos comprobados:
- El repositorio contiene la documentación del proyecto y los documentos del proceso definidos por la plantilla.
- GDD.md define "Mega Plataformas" y plantea como problema de diseño el ajuste de la altura del salto.
- El alcance definido excluye modificaciones al movimiento, enemigos, monedas y Powers-Ups.
- No se encontró una implementación de Unity del juego dentro del repositorio actual.
- No se encontraron scripts .cs, escenas .unity ni una carpeta Assets/ que permitan identificar un controlador de personaje o una variable concreta de salto.
  
Supuestos por verificar: 
- La futura implementación del juego utilizará Unity, de acuerdo con lo definido en la documentación del proyecto.
- La altura del salto podrá ajustarse sin modificar el movimiento horizontal, pero esto no puede comprobarse técnicamente hasta que exista una implementación.
  
Preguntas para consultar:
- ¿Qué implementación concreta del personaje y del salto se utilizará cuando el proyecto sea incorporado al repositorio?
- ¿Qué valor de altura del salto permitirá alcanzar las plataformas previstas?
- ¿Qué prueba concreta permitirá verificar el criterio de aceptación cuando exista una implementación ejecutable?
- ¿Cómo se comprobará que el movimiento horizontal permanece sin modificaciones?
