
# there are two webserver, one WebListener, two kestrel
# commands to run
k web 

#or
k kestrel

#in case of problems with set up
current version of aspnet 5 that has just got most of the commands renamed from K prefix to DN prefix.
So has to reset the aspnet 5 code to point to beta 3 using the commit hash 8ec209d022c38c9f83324375b98caf54be12d659

# after doing it
kvm upgrade 

#followed by this from the project folder, this is similar to nuget restore, which is how it is called in next release
kpm restore