# Health System Documentation

## Health (obj) {

goal: This is an object you put on a character or player to track their health points (hp). This is meant for RPG style games, but it can be used in other projects as well.

### attributes

```
int hp //health points
Condition conditions[] //array of all current conditions
```

### properties

```
constr() => hp=0 or hp=hp
set/get
addHp() => += hp : void
nextTurn() : void
goal: After a turn, call this. This adds/removes hp and automatically removes any invalid conditions.
steps:
for each condition(i) in array
  add what the condition returns to hp
  check of condition is valid
  if not, remove it from the list
```

}

## Condition (obj) {

### attributes

```
int hpModifier
```

### properties

```
constr() => hp=0 or hp=hp
get/set

hpFormula() //this is meant to be replaced in a child function, this returns an int to be added to hp
isValid() //this is meant to be replaced in a child function, this returns false if condition should be removed from the player
```

}