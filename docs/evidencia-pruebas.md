# Evidencia de pruebas

Relaciona cada criterio de aceptacion con una prueba o secuencia manual que otra persona pueda repetir.

| Criterio | Version validada | Metodo o comando | Pasos | Resultado esperado | Resultado observado | Evidencia |
|---|---|---|---|---|---|---|
| Altura del salto del personaje es suficiente para alcanzar plataformas previstas | Commit 57df515 | Prueba manual en Unity Editor | 1. Abrir el proyecto en Unity. 2. Ejecutar la escena en modo Play. 3. Mover el personaje hasta la posición necesaria. 4. Presionar Espacio para realizar el salto. 5. Observar el alcance de las plataformas previstas. | El personaje alcanza las plataformas previstas y mantiene operativo su movimiento. | El personaje alcanza las plataformas previstas y el movimiento continúa operativo. | Commit 57df515|

# Caso limite

| Criterio | Version validada | Metodo o comando | Pasos | Resultado esperado | Resultado observado | Evidencia |
|---|---|---|---|---|---|---|
| Una plataforma situada fuera del alcance máximo del salto no debe poder alcanzarse. | Commit 57df515 | Prueba manual en Unity Editor | 1. Ejecutar la escena en modo Play. 2. Intentar alcanzar una plataforma situada fuera del alcance máximo del salto. 3. Observar el resultado. | El personaje no alcanza la plataforma que está fuera del alcance del salto. | Pendiente de validación específica. | Commit 57df515|

## Fallos y limites pendientes

- Reproducción: El camino principal fue probado en Unity Editor mediante modo Play. El caso límite requiere una comprobación específica.
- Impacto: El cambio realizado se limita al ajuste de fuerzaSalto.
- Decisión: Se considera corregido el problema principal. La validación específica del caso límite queda pendiente si no se ejecutó durante la revisión.
