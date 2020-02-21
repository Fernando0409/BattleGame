# Modo de Juego e Instrucciones :video_game:
El mapa esta dividido en 6 regiones/continentes con máximo de 6 jugadores y un mínimo de 2, el 
juego tendrá la opción de que sea multijugador o contra la computadora.

Podremos encontrar dos modos diferentes de juego, el normal y rápido. En el modo normal los 
jugadores realizaran el proceso de selección de territorios y cantidad de tropas que se desean 
colocar en cada territorio, este paso será ejecutado uno por uno secuencialmente hasta que todos 
los territorios hayan sido ocupados. Mientras tanto en el modo rápido, los territorios concedidos y 
tropas serán dadas aleatoriamente. El orden de participación será dado según el numero obtenido 
por los jugadores, este orden será de manera descendente. La obtención del numero será de 
forma aleatoria para los jugadores, simulando el lanzamiento de los dados.


## Tropas y refuerzos  :guardsman: :guardswoman:
Una vez que se tiene el orden de los jugadores, cada uno de ellos escogerá la ubicación de sus 
tropas y cuantas de ellas desea colocar en el territorio. La cantidad de tropas que tenga cada 
jugador depende de la cantidad de jugadores totales:
	Si son 2 jugadores: 40 ejércitos cada uno
	Si son 3 jugadores: 35 ejércitos cada uno
	Si son 4 jugadores: 30 ejércitos cada uno
	Si son 5 jugadores: 25 ejércitos cada uno
	Si son 6 jugadores: 20 ejércitos cada uno

Además de esto, los jugadores podrán incorporar mas tropas a su plantilla en cada turno, la 
cantidad de nuevas tropas (refuerzos) es de acuerdo a la cantidad de territorios y/o continentes 
dominados:

| Territorios Ocupados | Tropas |
| :------------------: | :----: |
|         < 9          |   3    |
|        9 - 11        |   3    |
|        12 -14        |   4    |
|        15 -17        |   5    |
|       18 - 20        |   6    |
|        21 -23        |   7    |
|        24 -26        |   8    |
|        27 -29        |   9    |
|       30 - 32        |   10   |
|       33 - 35        |   11   |
|       36 - 38        |   12   |
|       39 - 41        |   13   |

Además si se tiene el control (total) de algún continente/región  se podrán obtener más tropas:

|    Continente     | No. de tropas |
| :---------------: | :-----------: |
|      África       |       3       |
|      Oceanía      |       2       |
|       Asia        |       7       |
|      Europa       |       5       |
| América del Norte |       5       |
|  América del Sur  |       2       |


## Ataque y Defensa :boom: :gun: 

Una vez que los jugadores tengan listas sus tropas y el orden de participación, los jugadores 
dentro de su turno podrá decidir si atacar a un territorio enemigo. Si el jugador decide atacar a un 
territorio ese territorio debe tener una frontera colindante entre ellos, por ejemplo, no se puede 
atacar desde Argentina a Gran Bretaña por el contrario México si puede atacar a Venezuela pues 
son territorios colindantes. Además desde el territorio atacante se debe tener como mínimo 2 
tropas, se puede atacar hasta eliminar las tropas enemigas o desde otro territorio colindante, 
incluso se puede cambiar el territorio atacado.

Una vez seleccionado el territorio el atacante deberá dictar con cuantas tropas atacara, en su 
contraparte, el jugador defensor deberá especificar con cuantas tropas defenderá, para ambos 
casos el máximo de tropas es de 3 (para atacar y defender). 

Para definir el ganador del combate la computadora generara **N** números aleatorios donde **N** es el 
numero de tropas ordenándolos de manera descendente, en este caso si el atacante decide 
atacar con 3 tropas se generaran 3 números aleatorios y si el defensor defiende con 2 tropas se 
generaran 2 números aleatorios, para después ordenarlos descendentemente respectivamente de 
cada jugador. Una vez ordenados los números se comparan entre ellos (el mayor del atacante y el 
mayor del defensor y así sucesivamente), el numero mayor de cada pareja es el ganador 
eliminando la tropa enemiga. Si el defensor utiliza un numero inferior de las tropas con la que se le 
ataca y es resulta ganador, el numero de tropas será el numero de tropas eliminadas será el 
numero de tropas defendidas. 

### Ejemplo
	Solo utiliza 1 tropa para defender y el enemigo ataca con 2 o 3, y 
	el numero mayor es del defensor la  cantidad de tropas que se 
	eliminan es 1, en caso de defender con 2 tropas, el atacante usa 3 
	tropas y los numeros mayores por pareja gana el defensor solo 
	elimina 2 tropas del atacante. 

En caso de empate el jugador defensor gana.

Nota: 
Además de poder atacar un territorio enemigo, el jugador puede mover sus tropas a sus diferentes 
territorios respetando la norma de que las fronteras de los territorios son colindantes. Su turno 
termina hasta que pierde un territorio o decide dejar de atacar.

## Distribución del mapa :dart: :world_map:

La distribución de los territorios se puede ver en la siguiente imagen:
![Distribución de los territorios](https://en.wikipedia.org/wiki/File:Risk_game_map.png)