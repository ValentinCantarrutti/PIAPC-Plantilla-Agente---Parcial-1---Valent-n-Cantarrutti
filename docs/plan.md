# Plan de intervencion

## Objetivo del plan

Definir una modificación mínima que permita ajustar la altura del salto del personaje para que pueda alcanzar las plataformas previstas, manteniendo sin cambios las demás mecánicas del juego y respetando los criterios de aceptación establecidos en la especificación.

## Cambios propuestos

| Paso | Cambio minimo | Archivos previstos | Verificacion | Riesgo | Condicion de detencion |
|---:|---|---|---|---|---|
| 1 | Ajustar la altura del salto del personaje para que pueda alcanzar las plataformas previstas. | Sistema de salto del personaje. | Realizar una prueba de salto y comprobar que el personaje alcanza las plataformas previstas. | Una altura excesiva podría permitir alcanzar plataformas que no correspondan al diseño. | Detenerse si no está claro qué valor de salto corresponde, si el cambio requiere modificar otras mecánicas o si aparecen cambios fuera del alcance definido. |

## Orden de implementacion

Primero se deberá revisar la propuesta de modificación del sistema de salto y comprobar que se limita al alcance definido. Luego se ajustará únicamente la altura del salto del personaje y se verificará que pueda alcanzar las plataformas previstas.

A continuación se deberá comprobar que el cambio no modifica otros movimientos ni las mecánicas de monedas, enemigos o Powers-Ups. Si durante la implementación aparece la necesidad de modificar otros sistemas, se deberá detener el proceso y revisar el alcance antes de continuar.

## Fuera de alcance

- Modificar otros movimientos del personaje.
- Modificar comportamientos de enemigos.
- Modificar sistema de monedas.
- Modificar los Powers-Ups.
- Agregar nuevas mecánicas o niveles.
- Realizar modificaciones en otros sistemas que no sean necesarios para ajustar la altura del salto.
