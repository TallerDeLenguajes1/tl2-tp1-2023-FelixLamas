# Tp1-2023-FelixLamas

## ¿Cuál de estas relaciones consideraquese realizapor composición y cuál por agregación?

La relacion de pedidos con cliente es una composicion, ya que en el diagrama si se elimina un pedido se debe eliminar el cliente.
La relacion cadete con pedidos es una agregacion, ya que un pedido puede ser reasignado para otro cadete.
La relacion del cadete con la cadeteria, es de agregacion ya que el diagrama se podria eliminar la cadeteria y el cadete seguir existiendo.

## ¿Qué métodos considera quedebería tener la clase Cadetería y la claseCadete?

la clase cadeteria deberia tener:
tomarPedido(cadete, pedido);
eliminarPedido(cadete,pedido);
reasignarCadete(cadete, pedido);
generarInforme(listado cadetes);

la case cadete deberia tener:
tomarPedido(pedido);
eliminarPedido(pedido);
reasignarCadete(pedido);

## Teniendoen cuenta los principios de abstracción y ocultamiento, queatributos propiedades y métodos deberían ser públicos y cuáles privados.

Los atributos de la clase cliente deben ser publicos para que se puedan acceder desde la clase pedido y mostarlos.
Los atributos de la clase pedido: solo cliente como atributo privado.
Los atributos de la clase cadete: solo el listado de pedidos como atributo privado.
Para la clase cadeteria el listado de cadetes como atributo privado.

## ¿Cómo diseñaría los constructores de cada una de las clases?

para los constructores los haria con parametros para poder inicializarlos cuando se instancie el objeto

## ¿Se le ocurre otra forma que podría haberse realizado el diseño de clases?

si haria que la clase cadeteria pudiera crear tengo una relacion de composicion con pedido y pedido una relacion de agregacion con cliente para que mi cliente pueda solicitar otros pedidos sin ser creado como cliente nuevo
