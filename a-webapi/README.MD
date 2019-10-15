```
docker build -t a-webapi . 
```

expose public port
```
docker run -p 5300:5000 a-webapi  
```
expose on host port 
``` 
 docker run --network host  a-webapi
 ```


