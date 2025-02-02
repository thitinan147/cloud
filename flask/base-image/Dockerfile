FROM ubuntu:20.04
RUN apt-get update && apt-get install -y python3 python3-pip
WORKDIR /app
ONBUILD COPY . /app
RUN pip3 install flask
EXPOSE 5002
ONBUILD CMD [ "python3", "testDockerfileFlask.py" ]