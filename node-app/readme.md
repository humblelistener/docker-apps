#Command to Build the docker image
$ docker build -t <your username>/centos-node-hello .

#check the created docker image
$ docker images

# run the image
$ sudo run -p 49160:8080 -d <your username>/centos-node-hello

# verify the container is created in docker host
$ docker ps

# make a request to your sample app
$ curl -i localhost:49160


# a few useful command

# to start the boot to docker - that will the first step, this will start the linux vm and start the host

boot2docker start

# to ssh into the docker host
boot2docker ssh

# to get the ip for docker host
boot2docker ip