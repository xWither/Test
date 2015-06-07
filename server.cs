function serverCmdHello(%client)
{
  messageAll('',"\c4" @ %client.name SPC "\c6said hello!")
}
