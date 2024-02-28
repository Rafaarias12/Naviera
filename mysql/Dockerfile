FROM docker/whalesay:latest
LABEL Name=mysql Version=0.0.1
COPY Script.sql /docker-entrypoint-initdb.d/
RUN apt-get -y update && apt-get install -y fortunes
CMD ["sh", "-c", "/usr/games/fortune -a | cowsay"]
