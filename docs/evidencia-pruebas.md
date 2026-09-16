# Evidencia de pruebas

Relaciona cada criterio de aceptacion con una prueba o secuencia manual que otra persona pueda repetir.

| Criterio | Version validada | Metodo o comando | Pasos | Resultado esperado | Resultado observado | Evidencia |
|---|---|---|---|---|---|---|
| Altura del salto del personaje es suficiente para alcanzar plataformas previstas | Commit e15a49d | Modificacion de variable pública en C# | 1. Localizar archivo Jugador.cs en Juego/Assets/Scripts/ 2. Cambiar valor de fuerzaSalto de 4f a 6f 2. Ejecutar Unity en modo Play 3. Presionar tecla de salto desde borde de plataforma inalcanzable | Personaje alcanza plataformas antes inalcanzables manteniendo movimiento horizontal | Personaje alcanza plataformas antes inalcanzables, movimiento horizontal se mantiene en 5f | Commit e15a49d en GitHub: https://github.com/ValentinCantarrutti/PIAPC-Plantilla-Agente---Parcial-1---Valent-n-Cantarrutti/commit/e15a49d |

## Fallos y limites pendientes

- Reproduccion: Probada exitosamente en Unity Editor modo Play con el script Jugador.cs
- Impacto: Ajuste menor dentro del alcance definido, sin afectar otras mecánicas
- Decision: Corregido - se incremento fuerzaSalto de 4f a 6f como intervencion minima
