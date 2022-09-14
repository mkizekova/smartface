# SmartFace Cloud Matcher
SmartFace Cloud Matcher enables your application to easily identify a person by comparing their live image with a reference image previously stored in a watchlist. Your application provides an image to the Cloud Matcher API, and the service provides highly accurate facial detection and identification. The lightweight identification of a person can be used for a variety of use cases where a fast identification of people is required and where you can register people's faces into the watchlist, including access control, 2nd factor authentication, retail and many other.

The provided docker images are intended for use the Cloudmatcher on Nvidia Jetson devices

Note that the jetson docker containers need to be run in privileged mode. This is because we need specific system files available in the container to properly check license usage.


## Deployment
1. Install `Docker` and `docker compose` on the host machine.
2. Login to container registry `docker login registry.gitlab.com -u <username> -p <password>`. The credentials are available in our [CRM portal](https://crm.innovatrics.com/).
3. Identify hardware id (hwid) for your machine with command `docker run registry.gitlab.com/innovatrics/smartface/license-manager:3.2.7`. This process work for native linux, for `WSL2` eg. linux containers on Windows you need special license for which you need to contact our sales.
4. Obtain license for your hwid from our CRM https://crm.innovatrics.com/client/products
5. Copy the license file `iengine.lic` to the root of this directory.
6. Run `run.sh` script. The run scripts contain comments which should clarify the steps needed to start everything
