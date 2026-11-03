![Lasagna](https://assets.exercism.org/exercises/lasagna.svg) **Lucian's Luscious Lasagna**

<p>A program that calculates cooking and preparation times for a lasagna recipe, including the expected oven time, preparation time, remaining cooking time, and total elapsed time.</p>

## Overview

The `Lasagna` class provides methods to calculate different time measurements involved in preparing and cooking a lasagna.

It uses a few simple calculations to determine how long the lasagna should stay in the oven, how much cooking time remains, and how long preparation takes based on the number of layers.

### Getting Started

#### 1. Creating a Lasagna Object

To use the methods, first create a new `Lasagna` object.

```csharp
Lasagna food = new Lasagna();
```

### 2. Available Methods

#### `ExpectedMinutesInOven()`

Returns the expected cooking time for the lasagna.

```csharp
int expectedTime = food.ExpectedMinutesInOven();
```

**Returns:** `int`

Example output:

```text
40
```

#### `RemainingMinutesInOven(int MinutesInOven)`

Calculates how many minutes are left until the lasagna reaches its expected cooking time of 40 minutes.

```csharp
int remainingTime = food.RemainingMinutesInOven(30);
```

**Returns:** `int`

Example: If the lasagna has been in the oven for 30 minutes, the remaining time is 10 minutes.

#### `PreparationTimeInMinutes(int NumberOfLayers)`

Calculates the preparation time based on the number of lasagna layers.

Each layer requires 2 minutes of preparation.

```csharp
int preparationTime = food.PreparationTimeInMinutes(2);
```

**Returns:** `int`

Example: 2 layers require 4 minutes of preparation.

#### `ElapsedTimeInMinutes(int NumberOfLayers, int MinutesInOven)`

Calculates the total elapsed time by adding the preparation time to the time already spent in the oven.

```csharp
int elapsedTime = food.ElapsedTimeInMinutes(4, 8);
```

**Returns:** `int`

Example: 4 layers require 8 minutes of preparation. If the lasagna has already spent 8 minutes in the oven, the total elapsed time is 16 minutes.

---

## Example Usage

```csharp
Lasagna food = new Lasagna();

Console.WriteLine($"Expected Minutes in Oven: {food.ExpectedMinutesInOven()} Minutes");

Console.WriteLine($"Remaining Minutes in Oven: {food.RemainingMinutesInOven(30)} Minutes");

Console.WriteLine($"Preparation Time in Minutes: {food.PreparationTimeInMinutes(2)} Minutes");

Console.WriteLine($"Elapsed Time in Minutes: {food.ElapsedTimeInMinutes(4, 8)} Minutes");
```

**Output:**

```text
Expected Minutes in Oven: 40 Minutes
Remaining Minutes in Oven: 10 Minutes
Preparation Time in Minutes: 4 Minutes
Elapsed Time in Minutes: 16 Minutes
```

## Method Summary

| Method | Description | Return Type |
|---|---|---|
| `ExpectedMinutesInOven()` | Returns the expected oven time. | `int` |
| `RemainingMinutesInOven()` | Calculates the remaining oven time. | `int` |
| `PreparationTimeInMinutes()` | Calculates preparation time based on layers. | `int` |
| `ElapsedTimeInMinutes()` | Calculates total preparation and cooking time. | `int` |

---

## Technologies Used

- C#
- .NET
- Object-Oriented Programming (OOP)

**Made with ❤︎ by AbduliP**
