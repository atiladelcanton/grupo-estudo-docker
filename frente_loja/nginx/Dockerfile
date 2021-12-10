FROM nginx:latest
RUN apt-get update && apt-get install -y
RUN apt-get install dnsutils -y
RUN CONFIG="\--with-http_stub_status_module"
RUN set -x \
  && apt-get update && apt-get upgrade -y \
  && apt-get install --no-install-recommends --no-install-suggests -y apt-transport-https ca-certificates gnupg1

WORKDIR /var/www