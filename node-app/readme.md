### commands used to dockerize

* to Build the docker image
`docker build -t <your username>/centos-node-hello .`

* check the created docker image
`docker images`

* run the image
`docker run -p 49160:8080 -d <your username>/centos-node-hello`

* verify the container is created in docker host
`docker ps`

* make a request to your sample app
`curl -i localhost:49160`

_incase if you are using boot2docker, you may have to use the ip of the boot2docker vm, depending on how the network is established during installation of boot2docker. Alternatively, you can ssh into vm and directly give the commands_

### useful boot2docker commands

* to start the boot to docker - that will the first step, this will start the linux vm and start the host**
`boot2docker start`

* to ssh into the docker host
`boot2docker ssh`

* to get the ip for docker host
`boot2docker ip`