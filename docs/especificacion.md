# Especificacion

## Problema

El salto del personaje es demasiado bajo y no permite alcanzar algunas plataformas del nivel, las modificaciones buscan solucionar este problema para que el jugador pueda avanzar por los niveles.

## Resultado esperado

El personaje debe poder saltar con la altura suficiente para que el jugador pueda dirigir el personaje y se alcancen las plataformas.

## Alcance

- Incluye: Modificaciones relacionadas con el salto del personaje.
- No incluye: Modificaciones a mecánicas de monedas, enemigos, Powers-Ups o otras.
  
## Restricciones

- Técnicas: El proyecto se plantea usando Unity 2D, modificando el salto del personaje.
- Operativas: No se modificaran otras mecánicas fuera del alcance definido.
- De calidad: El comportamiento se comprobara mediante una prueba de salto del personaje.

## Casos y criterios de aceptacion

| Caso | Dado | Cuando | Entonces | Evidencia |
|---|---|---|---|---|
| Camino principal | El personaje está sobre el suelo y puede saltar. | El jugador presiona el botón de salto y utiliza las flechas de dirección. | El personaje realiza un salto con altura suficiente y puede dirigirse horizontalmente para alcanzar la plataforma prevista. | Prueba de juego en la que el personaje realiza el salto y alcanza la plataforma. |
| Caso limite | El personaje intenta alcanzar una plataforma situada fuera de la altura máxima de salto. | El jugador realiza un salto intentando llegar a dicha plataforma. | El personaje no puede alcanzar la plataforma debido a que se encuentra fuera del alcance del salto. | Prueba de juego registrando el intento y el resultado. |
| Error | El personaje no alcanza una plataforma que está prevista para ser alcanzable. | El jugador realiza el salto necesario para llegar a ella. | Se registra que el comportamiento no cumple el criterio de aceptación. | Registro de la prueba y resultado observado. |

## Invariantes

- El jugador tiene que mantener el control horizontal durante el salto.
- Las modificaciones realizadas para mejorar el salto no deben alterar las demás mecánicas incluidas fuera del alcance.

## Preguntas abiertas

- ¿Qué altura exacta debe tener el salto para que todas las plataformas previstas sean alcanzables?
