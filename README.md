# avrogen-bug-repro
Reproduction of the avrogen code generation bug. This code is not compilable due to issue in code generation

Generated code is added to the repository under Test->Avro folder, you can regenerate this folder by running

```
avrogen -s Reproschema.avsc .
```

Note that the issue appears due to the namespace ending with ".Avro"
