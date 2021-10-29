FROM php:8-alpine

RUN apk add --no-cache mysql-client wget openssl libzip-dev zip unzip git bash curl  freetype-dev \
    libjpeg-turbo-dev \
    libjpeg-turbo \
    libpng-dev \
    libzip-dev \
    jpeg-dev 

RUN apk add --no-cache --virtual build-essentials &&\
    docker-php-ext-install pdo && \
    docker-php-ext-install pdo_mysql && \
    docker-php-ext-install zip && \
    docker-php-ext-configure gd --with-freetype --with-jpeg && \
    docker-php-ext-install gd && \
    docker-php-ext-install intl && \
    docker-php-ext-install curl && \
    docker-php-ext-install mcrypt && \
    docker-php-ext-install json && \
    apk del build-essentials && rm -rf /usr/src/php*