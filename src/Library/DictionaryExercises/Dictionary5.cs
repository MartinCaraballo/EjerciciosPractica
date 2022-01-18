/*
    Escribir una función que permite organizar el envío masivo de emails para propagandas publicitarias. 
    La función recibe un diccionario donde la clave es el nombre de una persona y el valor asociado es una lista de sus direcciones de correo electrónico (“emails”).

    Por ejemplo:

    emails={"Martín Rodríguez":["arodri@ucu.edu.uy", "rodriguez@gmail.com"], "Marcela Rodríguez":["mleites@gmail.com", "rodriguez@gmail.com"], "Juan Lamas":["jlamasucu.edu.uy", "juan.lamas@gmail.com"]}

    La función debe devolver el diccionario, eliminando cualquier email que esté duplicado (dos personas pueden estar con el mismo email) y además debe eliminar cualquier email que no contenga al menos un carácter “@” y un carácter “.”

    Devolución con parámetro anterior:
    emails={"Martín Rodríguez":["arodri@ucu.edu.uy", "rodriguez@gmail.com"], "Marcela Rodríguez":["mleites@gmail.com"], "Juan Lamas":["juan.lamas@gmail.com"]}

    Se eliminó "rodriguez@gmail.com" de Marcela porque ya existía y "jlamasucu.edu.uy" porque no tiene @.
*/