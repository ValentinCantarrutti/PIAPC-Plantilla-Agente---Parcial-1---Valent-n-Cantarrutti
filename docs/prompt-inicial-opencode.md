# Prompt inicial para OpenCode

Copia y adapta el siguiente prompt al abrir el agente por primera vez. Su objetivo es comprender el proyecto; no debe crear ni completar entregables con informacion inventada.

```text
Estoy iniciando un repositorio individual para un proyecto academico de
videojuegos basado en la plantilla PIAPC.

Antes de modificar archivos, preguntame:
1. Que motor de videojuegos usare y que version.
2. El nombre del proyecto.
3. Mi nombre y apellido.
4. Que comportamiento o problema de diseno debo trabajar.

Luego lee README.md, AGENTS.md, GDD.md y docs/. Explora la estructura real del
proyecto e identifica archivos, configuraciones, pruebas e instrucciones que
dependan del motor elegido.

No completes GDD.md ni documentos de docs/ con informacion inventada. Indica
que datos debe aportar el estudiante y que evidencia debe reunir para completar
cada documento.

No modifiques archivos, no ejecutes comandos, no instales dependencias, no uses
red y no publiques cambios. Presenta el resultado en este orden:
1. Hechos encontrados.
2. Supuestos y preguntas abiertas.
3. Estructura detectada.
4. Proximos pasos para completar la auditoria.
5. Condiciones para detenerse y consultar.
```

# Adaptación utilizada para este proyecto

```text
El siguiente prompt fue utilizado para realizar la primera exploración del repositorio del Parcial 1:

Estoy iniciando el trabajo sobre este repositorio individual para el Parcial 1 de Desarrollo Agéntico Documentado.

Antes de modificar archivos, necesito que tengas en cuenta la información ya definida en el proyecto:

- Motor: Unity.
- Nombre del proyecto: Plataformero 2D.
- Problema de diseño: la altura del salto del personaje es insuficiente para alcanzar algunas plataformas previstas.
- Alcance: ajustar únicamente la altura del salto, sin modificar el movimiento horizontal, enemigos, monedas, Power-Ups ni otras mecánicas.

Lee README.md, AGENTS.md, GDD.md y los documentos disponibles dentro de docs/. Explorá la estructura real del repositorio e identificá los archivos, configuraciones, pruebas e instrucciones que realmente existan.

No modifiques archivos, no ejecutes comandos, no instales dependencias, no uses la red y no accedas a secretos o credenciales.

No completes ningún documento con información inventada. No inventes scripts, escenas, pruebas, archivos, comandos ni una implementación del juego que no esté presente.

Determiná el estado actual del repositorio únicamente a partir de evidencia disponible.

Presentá el resultado en este orden:

1. Hechos encontrados.
2. Supuestos y preguntas abiertas.
3. Estructura detectada.
4. Estado de la implementación relacionada con el problema del salto.
5. Qué debería comprobarse antes de realizar una modificación.
6. Próximos pasos para completar la auditoría.
7. Condiciones para detenerse y consultar.

La propuesta debe respetar el alcance definido: modificar únicamente la altura del salto del personaje y no alterar el movimiento horizontal ni las mecánicas de enemigos, monedas o Power-Ups.
```

No implementes ninguna modificación todavía.
