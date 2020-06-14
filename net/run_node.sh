#!/usr/bin/env bash

# install docker
sudo apt-get update
sudo apt-get install -y docker.io
sudo systemctl enable docker.service
sudo systemctl start docker.service

# install compose

sudo curl -L "https://github.com/docker/compose/releases/download/1.26.0/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose
sudo chmod +x /usr/local/bin/docker-compose
sudo ln -s /usr/local/bin/docker-compose /usr/bin/docker-compose

# get stratis repo

wget --no-check-certificate -q https://github.com/stratisproject/StratisBitcoinFullNode/archive/DeveloperEdition.zip
sudo apt-get -y install unzip
unzip "DeveloperEdition.zip"
cd "StratisBitcoinFullNode-DeveloperEdition/"
sudo docker pull stratisgroupltd/blockchaincovid19:latest

cd Docker 
cd Docker-Compose/
# edit compose file w/ `tty: true` and `stdin_open: true` before image field

sudo iptables -A INPUT -p tcp -m tcp --dport 37223 -s 0.0.0.0/0 -j ACCEPT
sudo docker-compose -f -d 3-NodeNetwork.yml up