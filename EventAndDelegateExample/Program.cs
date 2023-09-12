namespace EventAndDelegateExample
{
    /// <summary>
    /// Delegate for handling temperature change events.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">Temperature change event arguments.</param>
    public delegate void TemperatureChangeHandler(object sender, TemperatureChangeEventArgs e);

    /// <summary>
    /// Custom event arguments class for temperature change events.
    /// </summary>
    public class TemperatureChangeEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the new temperature value.
        /// </summary>
        public float NewTemperature { get; }

        /// <summary>
        /// Gets the timestamp of the temperature change.
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureChangeEventArgs"/> class.
        /// </summary>
        /// <param name="newTemperature">The new temperature value.</param>
        /// <param name="timestamp">The timestamp of the temperature change.</param>
        public TemperatureChangeEventArgs(float newTemperature, DateTime timestamp)
        {
            NewTemperature = newTemperature;
            Timestamp = timestamp;
        }
    }

    /// <summary>
    /// Represents a temperature sensor that triggers temperature change events.
    /// </summary>
    public class TemperatureSensor : IDisposable
    {
        private List<TemperatureChangeHandler> subscribers = new List<TemperatureChangeHandler>();
        private float currentTemperature = 0.0f;
        private System.Timers.Timer timer;

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureSensor"/> class.
        /// </summary>
        public TemperatureSensor()
        {
            timer = new System.Timers.Timer(2000); // Update temperature every 2 seconds
            timer.Elapsed += (sender, e) => UpdateTemperature();
            timer.Start();
        }

        /// <summary>
        /// Gets the current temperature value.
        /// </summary>
        public float CurrentTemperature
        {
            get { return currentTemperature; }
            private set
            {
                if (currentTemperature != value)
                {
                    currentTemperature = value;
                    OnTemperatureChanged(new TemperatureChangeEventArgs(currentTemperature, DateTime.Now));
                }
            }
        }

        /// <summary>
        /// Event that is raised when the temperature changes.
        /// </summary>
        public event TemperatureChangeHandler TemperatureChanged
        {
            add
            {
                // Allow multiple subscribers
                subscribers.Add(value);
            }
            remove
            {
                subscribers.Remove(value);
            }
        }

        /// <summary>
        /// Raises the temperature change event and notifies all subscribers.
        /// </summary>
        /// <param name="e">Temperature change event arguments.</param>
        protected virtual void OnTemperatureChanged(TemperatureChangeEventArgs e)
        {
            // Notify all subscribers
            foreach (var subscriber in subscribers)
            {
                subscriber(this, e);
            }
        }

        /// <summary>
        /// Simulates updating the temperature value.
        /// </summary>
        private void UpdateTemperature()
        {
            Random rand = new Random();
            float newTemperature = (float)(rand.NextDouble() * 10 + 20); // Random temperature between 20°C and 30°C
            CurrentTemperature = newTemperature;
        }

        /// <summary>
        /// Disposes of the temperature sensor and stops the timer.
        /// </summary>
        public void Dispose()
        {
            timer.Stop();
            timer.Dispose();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor sensor1 = new TemperatureSensor();
            TemperatureSensor sensor2 = new TemperatureSensor();

            // Subscribe to sensor1's event
            sensor1.TemperatureChanged += HandleTemperatureChange;

            // Subscribe to sensor2's event
            sensor2.TemperatureChanged += (sender, e) =>
            {
                Console.WriteLine($"Sensor 2: Temperature changed to {e.NewTemperature}°C at {e.Timestamp}");
            };

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            // Unsubscribe from events
            sensor1.TemperatureChanged -= HandleTemperatureChange;
            sensor2.Dispose();
        }

        static void HandleTemperatureChange(object sender, TemperatureChangeEventArgs e)
        {
            Console.WriteLine($"Sensor 1: Temperature changed to {e.NewTemperature}°C at {e.Timestamp}");
        }
    }
}
