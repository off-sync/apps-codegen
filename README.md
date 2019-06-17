# Off-Sync.com Applications Code Generation

## Creating the ANTLR v4 C# Target

Also see the [online documentation](https://github.com/antlr/antlr4/tree/master/runtime/CSharp).

[Download](https://www.antlr.org/download.html) the ANTLR v4 tool.

Generate the C# target:

```bash
cd src/OffSync.Apps.Codegen.Infra.PlantUml/Antlr
java -jar antlr4.jar -Dlanguage=CSharp Applications.g4
```
