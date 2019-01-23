# IntArrayToHexArray
Convert a comma seperated int array to comma seperated hex array. Made to convert IRDEVKIT copied IR codes to hex

![alt text](https://github.com/kakopappa/IntArrayToHexArray/blob/master/Untitled.png)

```
string input = "12,13,14,15";

if (!String.IsNullOrEmpty(input)) {
    var selectedIds = input.Split(',').ToArray()
                .Where(i => !string.IsNullOrWhiteSpace(i)
                 && int.TryParse(i, out int validNumber))
                .Select(x => int.Parse(x).ToString("X")).ToList();

    string output = string.Join(", ", selectedIds);
}
```

Download IntArrayToHexArray.exe
