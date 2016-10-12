set SolutionDir=%1


MD %SolutionDir%LoassSolu.Ass\bin\config

XCOPY %SolutionDir%LoassSolu.Services\DAOS\config\*.config %SolutionDir%LoassSolu.Ass\bin\config /Y/R/I 


MD %SolutionDir%LoassSolu.Ass\bin\sqlMaps

XCOPY %SolutionDir%LoassSolu.Services\DAOS\sqlMaps %SolutionDir%LoassSolu.Ass\bin\sqlMaps /E/Y/I/R