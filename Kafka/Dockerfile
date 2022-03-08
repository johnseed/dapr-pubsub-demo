FROM mcr.microsoft.com/java/jdk:11-zulu-ubuntu

WORKDIR /app/kafka
COPY kafka_2.13-3.1.0.tgz .
COPY start.sh .
RUN tar -xzf kafka_2.13-3.1.0.tgz --strip-components=1 && rm -f kafka_2.13-3.1.0.tgz
EXPOSE 9092
ENTRYPOINT [ "bash", "start.sh" ]