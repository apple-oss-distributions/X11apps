# $Xorg: Xservers.fs,v 1.3 2000/08/17 19:54:17 cpqbld Exp $
#
# Xservers file, fileserver prototype (any machine without a display)
#
# Put X terminals which don't support XDMCP in this file; you will
# want to leave those terminals on and connected to the network, else
# xdm will have a tougher time managing them.
#
# Each line should look like:
#
#	XterminalName:0 foreign
