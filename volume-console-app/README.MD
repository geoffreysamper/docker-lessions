
build the container
```
docker build -t volume-console-app .
```

run the default without volume
```
docker run volume-console-app
```

create a volume
```
docker volume create vol
```

add a file to the volume
```
cd /var/lib/docker/volumes/vol/_data

echo from volume >>vol.txt

```

run with the volume mounted
```
docker run --mount source=vol,target=/vol volume-console-app /vol/vol.txt
```

