### What is purpose?
To prove that we can write asp.net web api's microservices that can run on linux container deployed using docker on aws.

### some of the gotchas

* aspnet 5 in its current form supports two webservers
  * asp weblistener - my guess this is just an evolution of owin self hosting
  * kestrel - this is interesting a nodejs like port for .net 


### commands to run the webser
`k web `

or
`k kestrel`

### in case of problems with set up
current version of aspnet 5 that has just got most of the commands renamed from K prefix to DN prefix. 
_So has to reset the aspnet 5 code to point to beta 3 using the commit hash 8ec209d022c38c9f83324375b98caf54be12d659. This commit hash point the code to beta 6 release_

### after doing it
`kvm upgrade `

### followed by this command from the project folder, this is similar to nuget restore, which is how it is called in next release
`kpm restore`


### commands used to dockerize the app

* used to build
`docker build -t karthikp/asp-app .`

* used to run
`docker run -t -d -p 1004:5004 karthikp/asp-app`

_-t switch attaches a pseudo-tty to the container (this switch will not be necessary in future versions of ASP.NET 5)_
[reference](http://blogs.msdn.com/b/webdev/archive/2015/01/14/running-asp-net-5-applications-in-linux-containers-with-docker.aspx)