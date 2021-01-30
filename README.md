# Examen-ingreso
Respuestas:
Por favor, especifica tu nombre completo: Facundo Nehuen Bengoa

¿C# permite herencia múltiple?
En C# solo se puede heredar de una clase, para hacer herencia múltiple hay que recurrir a la implementación de interfaces.

¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
Si bien su comportamiento es similar, utilizamos una interfaz cuando nos referimos a clases que comparten comportamientos, aunque no se trate de objetos del mismo tipo. Por ejemplo, un Avión, un Barrilete, y una Abeja pueden realizar la acción de Volar, pero esa es la única similitud. En este caso implementaríamos una interfaz con el método Volar().
Una clase abstracta, por otro lado, se refiere a objetos que son de una misma clase. Y no queremos que se creen objetos de la clase padre.
Por ejemplo, podríamos tener una clase abstracta Insecto, de la que hereden Abeja, Hormiga y Ciempiés.

¿Qué implica una relación de Generalización entre dos clases?
Significa que la clase hija es un caso especial de la clase padre. La clase hija hereda atributos, propiedades y métodos de la clase padre.

¿Qué implica una relación de Implementación entre una clase y una interfaz?
En este caso, estamos asegurando que la clase se comporta como lo dice la interfaz, es decir, implementa sus métodos. En este caso, es necesario especificar el código de cada método de la interfaz en la clase.

¿Qué diferencia hay entre la relación de Composición y la Agregación?
Si bien ambas relaciones hablan de un "todo" y sus "partes", en la Composición, las partes solo existen dentro del "todo", y no tienen sentido en un contexto fuera de él. Por ejemplo, una Mesa y sus Patas podría modelarse como Composición, ya que las Patas sin una Mesa ya no son Patas.
En la agregación, las partes sí pueden existir fuera del todo, y siguen existiendo si éste se elimina. Como ejemplo, podemos considerar un Taxi y su Chofer.

Indique V o F según corresponda. Diferencia entre Asociación y Agregación:
Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual.
V

Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1.
F

Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación.
F
