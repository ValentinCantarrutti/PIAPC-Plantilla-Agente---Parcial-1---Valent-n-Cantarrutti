# Matriz de permisos

Completa esta matriz antes de habilitar acciones de un agente. Una accion no declarada debe considerarse prohibida hasta consultar.

| Accion | Estado | Alcance o justificacion |
|---|---|---|
| Leer archivos del proyecto | Permitida | Necesario para conocer el estado del repositorio y analizar la documentación existente. |
| Buscar rutas y simbolos | Permitida | Permitido para localizar los elementos relacionados con el sistema de salto. |
| Editar archivos previstos | Pendiente | Se habilitará después de completar la exploración, especificación, plan y revisión de la propuesta. |
| Ejecutar scripts documentados | Pendiente | Se habilitará únicamente cuando exista una prueba o comando documentado y sea necesario para validar el cambio. |
| Instalar dependencias | Prohibida | No es necesario para la modificación planteada. |
| Usar red | Prohibida | No es necesaria para el trabajo. |
| Publicar o subir cambios | Prohibida | Los cambios serán revisados antes de realizar cualquier publicación. |
| Acceder a secretos o credenciales | Prohibida | No corresponde al trabajo. |

## Condiciones de detencion

- Detener la herramienta y consultar si aparece una ambigüedad sobre el comportamiento esperado.
- Detenerse si se requiere modificar archivos o sistemas fuera del alcance definido.
- Detenerse si se necesita instalar dependencias, usar la red o acceder a secretos o credenciales.
- Detenerse si se propone ejecutar un comando que no esté documentado o justificado.
- Detenerse si una validación falla y no se comprende la causa.
- Detenerse si aparecen cambios no relacionados con el objetivo de modificar la altura del salto.
