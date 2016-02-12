# Elite Companion API

This is a class library in c# for accessing the official api exposed by the Elite Dangerous Companion. This not an official library and is not endorsed by Frontier developments.

The library allows to manage multiple logins. Information about each login is stored on disk and the password is encrypted using the machine key. NOTE: cookie data is not encrypted at this point.

On first login an email will be sent from Frontier with a verification code. This can then be verified using the library.

An example on how to use the library can be seen in the EliteCompanionCommand-app.
