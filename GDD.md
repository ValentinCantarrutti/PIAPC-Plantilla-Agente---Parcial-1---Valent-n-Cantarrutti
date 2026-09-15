# GDD - Mega Plataformas

## Juego y experiencia

- Genero y situación de juego: Videojuego de acción plataformero 2D en el que el jugador deberá avanzar en torno a varios niveles saltando plataformas, adquiriendo Powers-Ups, recolectando monedas y derrotando a los enemigos que se encuentre.
- Rol del jugador: Iniciar la partida y controlar al personaje llevándolo por el nivel, haciendo que se mueva, salte plataformas, adquiera Powers Ups, recolecte monedas y derrote enemigos aplastándolos.
- Experiencia buscada: Que el jugador pueda controlar al personaje por el nivel, tome decisiones como si adquirir o no un Power-Up, esquivar o derrotar enemigos, que consiga la mayor cantidad de monedas posible en cada nivel y pase de niveles.

## Comportamiento a resolver

- Entidad: Personaje
- Problema actual: El salto de personaje es muy bajo y no permite alcanzar algunas plataformas del nivel.
- Comportamiento esperado: El personaje debe poder alcanzar todas las plataformas previstas mediante un salto con altura suficiente.

## Reglas

- Estados, condiciones o eventos relevantes: El personaje se encuentra en el suelo y puede realizar un salto.
- Acción del jugador o del entorno: El jugador presiona el botón de salto y las flechas de dirección.
- Resultado esperado: El personaje realiza un salto con la altura suficiente como para que el jugador pueda dirigirlo con las flechas de dirección a la plataforma.
- Caso límite: El jugador intenta alcanzar una plataforma que se encuentra fuera de la altura máxima de salto.

## Limites

- Fuera de alcance: No se modificaran otras mecánicas del juego, como las monedas, los enemigos o los Powers-Ups.
- Restricciones técnicas: Las modificaciones se deberán realizar sobre el sistema del movimiento del personaje sin modificar las demás mecánicas, se usara Unity 2D.
- Criterios de aceptación: El personaje deberá poder alcanzar mediante un salto la altura de las plataformas previstas de los niveles y el jugador debera poder guiar el movimiento horizontal durante el salto para que el personaje alcance las plataformas.

