```
docker build -t cmds-and-entrypoint .
```

no args uses default one
```
docker run cmds-and-entrypoint
```

override command line args 

```
docker run cmds-and-entrypoint  --file a.txt
```

more info https://goinbigdata.com/docker-run-vs-cmd-vs-entrypoint/