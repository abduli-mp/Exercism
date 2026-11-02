**Title:** Bird Watcher

**Description:** A Program that keeps track of how many birds have visited your garden in the last seven days.
---

## Overview

The `BirdCount` class is designed to store and manage the number of birds counted each day of the week.

It provides methods to retrieve daily counts, update today's count, check for days without birds, calculate totals, and identify busy days.

## Getting Started

### 1. Creating a BirdCount Object

To use the methods, first create an array containing the bird counts for each day.

```csharp
int[] birds = { 0, 2, 5, 3, 7, 8, 4 };

BirdCount birdCount = new BirdCount(birds);
```

The array represents seven days, starting from Monday to Sunday.

### 2. Available Methods

#### `LastWeek()`

Returns a predefined array containing the bird counts from last week.

```csharp
int[] lastWeek = BirdCount.LastWeek();
```

**Returns:** `int[]`

#### `Today()`

Returns the number of birds counted today.

```csharp
int today = birdCount.Today();
```

**Returns:** `int`

#### `IncrementTodaysCount()`

Increases today's bird count by one.

```csharp
birdCount.IncrementTodaysCount();
```

**Returns:** `void`

#### `HasDayWithoutBirds()`

Checks whether there is at least one day with zero birds.

```csharp
bool result = birdCount.HasDayWithoutBirds();
```

**Returns:** `bool`

- `true`: At least one day had zero birds.
- `false`: Every day had at least one bird.

#### `CountForFirstDays(int numberOfDays)`

Calculates the total number of birds counted during the first specified number of days.

```csharp
int total = birdCount.CountForFirstDays(3);
```

**Returns:** `int`

Example: If the first three days have counts of `0, 2, 5`, the result is `7`.

#### `BusyDays()`

Counts how many days had five or more birds.

```csharp
int busyDays = birdCount.BusyDays();
```

**Returns:** `int`

Example: With the array `{ 0, 2, 5, 3, 7, 8, 4 }`, the result is `3`.

---

## Example Usage

```csharp
int[] birds = { 0, 2, 5, 3, 7, 8, 4 };

BirdCount birdCount = new BirdCount(birds);

Console.WriteLine(birdCount.Today());
Console.WriteLine(birdCount.HasDayWithoutBirds());
Console.WriteLine(birdCount.CountForFirstDays(3));
Console.WriteLine(birdCount.BusyDays());

birdCount.IncrementTodaysCount();

Console.WriteLine(birdCount.Today());
```

## Method Summary

| Method | Description | Return Type |
|---|---|---|
| `LastWeek()` | Returns last week's bird counts. | `int[]` |
| `Today()` | Gets today's bird count. | `int` |
| `IncrementTodaysCount()` | Increases today's count by one. | `void` |
| `HasDayWithoutBirds()` | Checks for a day with zero birds. | `bool` |
| `CountForFirstDays()` | Calculates the total for the first N days. | `int` |
| `BusyDays()` | Counts days with five or more birds. | `int` |

---

## Technologies Used

- C#
- .NET

## Author

<!-- Enter your name here -->

