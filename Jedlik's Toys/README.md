![Jedlik's Toys](https://assets.exercism.org/assets/graphics/missing-exercise-54cf5afe4add37d9cf717793c91b088a7dd242ef.svg) **Jedlik's Toys**

<p>A program that simulates a remote-controlled car by tracking its driving distance and remaining battery percentage.</p>

## Overview

The `RemoteControlCar` class simulates a remote-controlled car with a battery that starts at 100%.

It provides methods to create a new car, drive it, display the total distance driven, and check the remaining battery level.

Each time the car is driven, it travels 20 meters and consumes 1% of its battery.

### Getting Started

#### 1. Creating a RemoteControlCar Object

To use the methods, first create a new `RemoteControlCar` object.

```csharp
RemoteControlCar car = new RemoteControlCar();
```

Alternatively, you can use the static `Buy()` method:

```csharp
RemoteControlCar car = RemoteControlCar.Buy();
```

A newly created car starts with:
- Distance driven: 0 meters
- Battery: 100%

### 2. Available Methods

#### `Buy()`

Creates and returns a new `RemoteControlCar` object.

```csharp
RemoteControlCar car = RemoteControlCar.Buy();
```

**Returns:** `RemoteControlCar`

#### `DistanceDisplay()`

Returns a string displaying the total distance driven by the car.

```csharp
string distance = car.DistanceDisplay();
```

**Returns:** `string`

Example output:

```text
Driven 40 meters
```

#### `BatteryDisplay()`

Returns a string displaying the remaining battery percentage.

If the battery reaches zero or below, it displays `"Battery empty"`.

```csharp
string battery = car.BatteryDisplay();
```

**Returns:** `string`

Example outputs:

```text
Battery at 98%
```

```text
Battery empty
```

#### `Drive()`

Simulates driving the remote-controlled car.

Each time this method is called:
- The car travels another 20 meters.
- The battery decreases by 1%.
- When the battery is empty, the car cannot drive any further.

```csharp
car.Drive();
```

**Returns:** `void`

---

## Example Usage

```csharp
RemoteControlCar car = RemoteControlCar.Buy();

car.Drive();
car.Drive();

Console.WriteLine(car.DistanceDisplay());
Console.WriteLine(car.BatteryDisplay());
```

**Output:**

```text
Driven 40 meters
Battery at 98%
```

## Method Summary

| Method | Description | Return Type |
|---|---|---|
| `Buy()` | Creates a new remote-controlled car. | `RemoteControlCar` |
| `DistanceDisplay()` | Displays the total distance driven. | `string` |
| `BatteryDisplay()` | Displays the remaining battery. | `string` |
| `Drive()` | Drives the car and consumes battery. | `void` |

---

## Technologies Used

- C#
- .NET
- Object-Oriented Programming (OOP)

**Made with ❤︎ by AbduliP**
