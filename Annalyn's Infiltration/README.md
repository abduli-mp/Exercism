![Annalyn's Infiltration](https://assets.exercism.org/exercises/annalyns-infiltration.svg) **Annalyn's Infiltration**

<p>A program that uses Boolean logic to determine whether Annalyn can perform different actions during a rescue mission, depending on whether the knight, archer, and prisoner are awake and whether her pet dog is present.</p>

## Overview

The `QuestLogic` static class contains methods that evaluate different situations during Annalyn's rescue mission.

It uses Boolean values (`true` and `false`) and logical operators such as `!` (NOT), `&&` (AND), and `||` (OR) to determine whether an action is possible.

Since the class is static, you do not need to create an object to use its methods.

### Getting Started

#### 1. Using the QuestLogic Class

To use the methods, simply call them directly using the class name.

```csharp
bool result = QuestLogic.CanFastAttack(false);
```

### 2. Available Methods

#### `CanFastAttack(bool knightIsAwake)`

Determines whether Annalyn can perform a fast attack.

A fast attack is only possible when the knight is asleep.

```csharp
bool result = QuestLogic.CanFastAttack(false);
```

**Returns:** `bool`

- `true`: The knight is asleep.
- `false`: The knight is awake.

#### `CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)`

Determines whether Annalyn can spy on the group.

Spying is possible if at least one of the three characters is awake.

```csharp
bool result = QuestLogic.CanSpy(true, false, false);
```

**Returns:** `bool`

- `true`: At least one character is awake.
- `false`: All three characters are asleep.

#### `CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)`

Determines whether Annalyn can signal the prisoner.

Signaling is only possible when the archer is asleep and the prisoner is awake.

```csharp
bool result = QuestLogic.CanSignalPrisoner(false, true);
```

**Returns:** `bool`

- `true`: The archer is asleep and the prisoner is awake.
- `false`: Either the archer is awake or the prisoner is asleep.

#### `CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)`

Determines whether Annalyn can free the prisoner based on the current situation.

There are two possible conditions:

1. The knight and archer are asleep, and the prisoner is awake.
2. Annalyn's pet dog is present, and the archer is asleep.

```csharp
bool result = QuestLogic.CanFreePrisoner(false, false, true, false);
```

**Returns:** `bool`

- `true`: At least one of the two conditions is satisfied.
- `false`: Neither condition is satisfied.

---

## Example Usage

```csharp
Console.WriteLine(QuestLogic.CanFastAttack(false));

Console.WriteLine(QuestLogic.CanSpy(true, false, false));

Console.WriteLine(QuestLogic.CanSignalPrisoner(false, true));

Console.WriteLine(QuestLogic.CanFreePrisoner(false, false, true, false));
```

**Output:**

```text
True
True
True
True
```

## Method Summary

| Method | Description | Return Type |
|---|---|---|
| `CanFastAttack()` | Checks whether a fast attack is possible. | `bool` |
| `CanSpy()` | Checks whether at least one character is awake. | `bool` |
| `CanSignalPrisoner()` | Checks whether the prisoner can be signaled. | `bool` |
| `CanFreePrisoner()` | Checks whether the prisoner can be freed. | `bool` |

---

## Technologies Used

- C#
- .NET
- Boolean Logic
- Logical Operators
- Static Methods

**Made with ❤︎ by AbduliP**