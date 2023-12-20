
  Vukhi sungluc;
  sungluc = new Vukhi(); 
  //sungluc = null; //thu hoi o nho va cap phat de tao ra doi tuong 
  sungluc.name = "Sungluc";
  sungluc.ThietlapDosatthuong(6);
  Vukhi sungmay = new Vukhi("Sung may", 20);
  sungluc.Noisx = "America";
  sungluc.Satthuong = 10;
  Console.WriteLine(sungluc.Satthuong);
  Console.WriteLine(sungluc.Noisx);
  
  sungluc.tanCong();
  sungmay.tanCong();






