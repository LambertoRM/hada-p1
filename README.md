Lamberto Ruiz Martínez

Práctica 1b. Uso de GitHub/remoto

P1:Se ha subido exactamente la rama master, lo he comprobado desde la página web de gitHub del repositorio 

P2: Al utilizar esta opción, se abre una nueva pestaña con el código sin modificar a la derecha y a la izquierda muestra las partes que se han modidicado en color verde.

P3: El único cambio visible es que tienes que actualizar la rama master local con la rama master del repositorio remoto. Por ello, aparece un commit nuevo.

P4: Confirmar por etapas significa añadir al repositorio local, git add

P5: Confirmar por etapas e insertar significa añadir algo y hacer commit al repositorio local, git add commit

P6: Confirmar por etapas y sincronizar significa añadir algo, hacer el commit y sincronizar todos esos cambios con el repositorio remoto, git add commit push.

P7: La diferencia principal es que sincronizar pone los commits que faltan en el repositorio local que estaban previamente en el remoto y extraer sincroniza las confirmaciones de entrada y de salida, o lo que es lo mismo, pone los commimts que faltan en el repositorio remoto respecto al local. El comando sería git pull para soncronizar tu repositorio local con el repositorio remoto y el otro es git push para actualizar el repositorio remoto con el local.

P8: Fusionar mediante combinación significa mezclar los cambios de dos ramas, el comando git equivalente sería merge.

P9: Fusionar mediante cambio de base significa unificar dos ramas dejando un árbol lineal. El comando equivalente sería rebase.
