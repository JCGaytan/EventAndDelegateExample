# Event and Delegate Example

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.txt)

## Technical Background

### Events

In C#, an event is a language feature that allows an object to notify other objects when something of interest happens. Events are a way to achieve a publish-subscribe pattern, where an object (the publisher) maintains a list of subscribers (event handlers) and notifies them when an event occurs.

Events consist of:

- An event declaration using the `event` keyword.
- An event handler delegate that specifies the signature of the methods that can subscribe to the event.
- Event registration using `+=` to add an event handler and `-=` to remove it.

In this example, the `TemperatureSensor` class raises a `TemperatureChanged` event when the temperature changes. Subscribers can attach event handlers to this event and respond to temperature updates.

### Delegates

Delegates in C# are reference types that represent methods with a specific signature. Delegates enable you to treat methods as first-class citizens, making it possible to pass methods as parameters, store them in data structures, and invoke them dynamically.

In the context of events, delegates are used to define the signature of event handler methods. The delegate type specifies the parameters and return type for the methods that can be subscribed to the event.

### Observer Pattern

Events and delegates are commonly used to implement the Observer Pattern. In this pattern, objects (observers) register their interest in another object (subject) and receive notifications when the subject's state changes. This promotes loose coupling between objects, making the code more maintainable and extensible.

## Usage

1. Open the solution in your preferred C# development environment.
2. Build and run the console application.
3. Observe temperature change notifications displayed in the console.
4. Press any key to exit the application.

## License

This project is licensed under the MIT License. See the [LICENSE.txt](LICENSE.txt) file for details.

---

**Español:**

# Ejemplo de Eventos y Delegados

[![Licencia](https://img.shields.io/badge/licencia-MIT-blue.svg)](LICENSE.txt)

## Antecedentes Técnicos

### Eventos

En C#, un evento es una característica del lenguaje que permite que un objeto notifique a otros objetos cuando ocurre algo de interés. Los eventos son una forma de lograr un patrón de publicación-suscripción, donde un objeto (el publicador) mantiene una lista de suscriptores (manejadores de eventos) y los notifica cuando se produce un evento.

Los eventos constan de:

- Una declaración de evento utilizando la palabra clave `event`.
- Un delegado manejador de eventos que especifica la firma de los métodos que pueden suscribirse al evento.
- El registro de eventos utilizando `+=` para agregar un manejador de eventos y `-=` para eliminarlo.

En este ejemplo, la clase `TemperatureSensor` genera un evento `TemperatureChanged` cuando la temperatura cambia. Los suscriptores pueden adjuntar manejadores de eventos a este evento y responder a las actualizaciones de temperatura.

### Delegados

Los delegados en C# son tipos de referencia que representan métodos con una firma específica. Los delegados le permiten tratar a los métodos como ciudadanos de primera clase, lo que permite pasar métodos como parámetros, almacenarlos en estructuras de datos e invocarlos dinámicamente.

En el contexto de eventos, los delegados se utilizan para definir la firma de los métodos manejadores de eventos. El tipo de delegado especifica los parámetros y el tipo de retorno para los métodos que pueden suscribirse al evento.

### Patrón Observador

Los eventos y los delegados se utilizan comúnmente para implementar el Patrón Observador. En este patrón, los objetos (observadores) registran su interés en otro objeto (sujeto) y reciben notificaciones cuando cambia el estado del sujeto. Esto promueve el desacoplamiento entre objetos, lo que hace que el código sea más mantenible y extensible.

## Uso

1. Abre la solución en tu entorno de desarrollo preferido de C#.
2. Compila y ejecuta la aplicación de consola.
3. Observa las notificaciones de cambio de temperatura que se muestran en la consola.
4. Presiona cualquier tecla para salir de la aplicación.

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo [LICENSE.txt](LICENSE.txt) para obtener más detalles.

---

**Français:**

# Exemple d'Événements et de Délégués

[![Licence](https://img.shields.io/badge/licence-MIT-blue.svg)](LICENSE.txt)

## Contexte Technique

### Événements

En C#, un événement est une fonctionnalité du langage qui permet à un objet de notifier d'autres objets lorsqu'un événement d'intérêt se produit. Les événements sont un moyen d'obtenir un modèle de publication-abonnement, où un objet (l'éditeur) maintient une liste d'abonnés (gestionnaires d'événements) et les notifie lorsque l'événement se produit.

Les événements se composent de :

- Une déclaration d'événement à l'aide du mot-clé `event`.
- Un délégué gestionnaire d'événements qui spécifie la signature des méthodes pouvant s'abonner à l'événement.
- L'enregistrement d'événements à l'aide de `+=` pour ajouter un gestionnaire d'événements et `-=` pour le supprimer.

Dans cet exemple, la classe `TemperatureSensor` déclenche un événement `TemperatureChanged` lorsque la température change. Les abonnés peuvent attacher des gestionnaires d'événements à cet événement et réagir aux mises à jour de température.

### Délégués

Les délégués en C# sont des types de référence qui représentent des méthodes ayant une signature spécifique. Les délégués vous permettent de traiter les méthodes comme des citoyens de première classe, ce qui rend possible de passer des méthodes en tant que paramètres, de les stocker dans des structures de données et de les invoquer dynamiquement.

Dans le contexte des événements, les délégués sont utilisés pour définir la signature des méthodes gestionnaires d'événements. Le type de délégué spécifie les paramètres et le type de retour des méthodes qui peuvent s'abonner à l'événement.

### Pat

## Utilisation

1. Ouvrez la solution dans votre environnement de développement C# préféré.
2. Compilez et exécutez l'application de consôle.
3. Observez les notifications de changement de température affichées dans la console.
4. Appuyez sur n'importe quelle touche pour quitter l'application.

## Licence

Ce projet est sous licence MIT. Consultez le fichier [LICENSE.txt](LICENSE.txt) pour plus de détails.
