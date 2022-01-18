/*
    - Modelar una clase auto, que tenga una marca, un color y un año. Agregar los métodos arrancar y frenar.

    - El caso anterior ha sido bien sencillo. Comencemos a agregar un poco de realismo y modifiquemos la clase anterior; dentro de los atributos agreguemos 
        la capacidad del tanque y el rendimiento (kilómetros por litro de nafta) (estos atributos deberán declararse en el constructor, además llevaremos un kilometraje 
        que inicialmente estará en 0). Cuando se defina un auto, el nivel del tanque de nafta deberá ser cero (es decir, está vacío de combustible). 
        Por lo tanto tendremos otros métodos que serán:

            - recorrer(kms): hace que el auto recorra tantos kms. Para esto debe verificar que el nivel de combustible alcance para poder 
                recorrerlos (deberá chequearse si hay combustible disponible, en función del rendimiento del auto). 
                Si el combustible no alcanza entonces el auto deberá mostrar por pantalla lo ocurrido 
                (y decir qué cantidad de kilómetros podría recorrer con la nafta disponible, pero se queda quieto).

            - cargar_nafta(litros): permite cargar litros al tanque. Si la cantidad de litros supera a la capacidad del tanque, se llenará el tanque y se informará por pantalla que 
                sobraron tantos litros.
*/