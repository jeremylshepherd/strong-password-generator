
# Strong Password Generator API

Creates a random string of Uppercase, lowercase, numerical, and symbols characters.

```
/strongpass
```
Will generate an array of 10 character strings, each 12 characters in length.
```json
[
"?%N9ZYGM8l{N",
"Y9?VF}c-AYu#",
"ll&yQH=kpS4m",
"5p&pBJFz&Tiy",
"R%_f!FSo9zo&",
"6MlK$YCY.hRS",
"3dng3$cET0aP",
"3PIVVDcXE~b#",
"2hoI+Z13LW{3",
"Hza=VYqP9#.I",
"JT$RFAlG$Z)("
]
```

Or you can pass your desired character length  as follows.
```
/strongpass/14
```
Which will produce a character string 14 characters in length such as...

```json
q)az%$FE}Kdtka
```