   M S B A M L   `   `   `  ����J  FEnglishByImages, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EnglishByImagesEnglishByImages  5   	        EnglishByImages.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EnglishByImages     5   	     � Title$  Study English by Images��5   	   $	��600��6)   $	��400��66    � 	Resources 5	         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButtonStyle �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%b  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6+   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 0q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $	 border��6!   $
 20��61   #��z��6C   #��z��6o   #��z��6�    . ._�5)      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted . . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver . . �50   "   �� $ border��6?    � �� �#EAB01E6S   �� 51   "   $ border��6@    � �� �#EAB01E6T   52      P� 53       � �� . . �54   "   �� $ border��6?    � �� �#F1CA686S   �� 55   "   $ border��6@    � �� �#F1CA686T   56      P� 57       � {� .  . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8   � ��6i   5;      5=      5?      5@      5A       � Icon 5C      �� 5D   
    �� 	UriSource$ Images/english.png?�6    �� BitmapScalingMode$ HighQuality=�65   .��5I      �� -   5         ��Name$ 
LayoutRoot��5I      .+�5J   
   �� -   5        $��EnglishImage��5J      $	��267��6$   $	��412��60    �� Left$ 60��5K      
 �� Top$ 50��6!   5M      �� 5Q   
   -   5        $��
NextButton��5R      $
��Next��5Q      $	��102��5R   #   $��45��6/   $	 225��5S      $	 491��6#    J� RenderTransformOrigin$ 0.558,0.438&�5T      ���	#FF64CCF1#��� 
 5U   (   
�������$��Arial)�5W      $��16(�5X      �� 5Z   
   -   5        $��StartButton��5[      $��Start��5Z      $��99��5[   $   $��44��6/   $ 60��5\      $	 492��6"   $ 0.558,0.438&�5]      ���	#FF64CCF1#��� 
 5^   (   
�������$��Arial)�5`      $��16(�5a      5d      5f      