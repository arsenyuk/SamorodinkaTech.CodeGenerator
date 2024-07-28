# SamorodinkaTech.CodeGenerator

Repository of the MAUI .NET 8 project with an application for recognizing patterns in text and generating code according to a given algorithm.

Currently using T4 technology to generate code.

Code is generated in C# for three templates:
- Newtonsoft.Json style json model,
- System.Text.Json style json model,
- asynchronous function to call a http GET method.

Для произвольных целей типа 
### Telegram bot API to Newtonsoft.Json style
```

```

### Telegram bot API to System.Text.Json style
```
    /// <summary>
    /// Document with the wallpaper
    /// </summary>
    [JsonPropertyName("document")]
    [JsonRequired]
    public TelegramDocument Document { get; set; }

    /// <summary>
    /// Optional.
    /// True, if the wallpaper is downscaled to fit in a 450x450 square and then box-blurred with
    /// radius 12
    /// </summary>
    [JsonPropertyName("is_blurred")]
    public bool? IsBlurred { get; set; }
```


For your own use, make a copy of this repository.