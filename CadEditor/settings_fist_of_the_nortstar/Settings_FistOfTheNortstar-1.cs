using CadEditor;
using System;
using System.Drawing;

public class Data 
{ 
  public GameType getGameType()        { return GameType.Generic; }
  public OffsetRec getScreensOffset()  { return new OffsetRec(0x01D4B7, 1 , 256); }
  public int getScreenWidth()          { return 32; }
  public int getScreenHeight()         { return 1; }
  public string getBlocksFilename()    { return "fist_of_the_nortstar_1.png"; }
  public int    getPictureBlocksWidth()   { return 16; }

// Width
  public bool isBigBlockEditorEnabled() { return false; }
  public bool isBlockEditorEnabled()    { return false; }
  public bool isLayoutEditorEnabled()   { return false; }
  public bool isEnemyEditorEnabled()    { return false; }
  public bool isVideoEditorEnabled()    { return false; }

  public bool getScreenVertical()         { return false; }
}