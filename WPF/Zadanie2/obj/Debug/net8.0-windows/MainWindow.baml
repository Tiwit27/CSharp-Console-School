   M S B A M L   `   `   `  ����C  ?Zadanie1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Zadanie1Zadanie1  5   	       Zadanie1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Zadanie1     5   	   -   5        $��window��5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   
������� � 
ResizeMode$ NoResize=�5
   	    � Icon$ grafika/ikona.ico��5   	   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      $��2* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��5q�6   
���   �$��10q�6=   $	��200��6I   ._�5      �� -   5        $��liczba1��5   ,   $��liczba x��6   $��40(�6;    �� Padding$ 10q�6I    �� TextAlignment$ Center=�6V   5      �� 5      -   5        $
��znak��5   g   $��*��6   $��80(�6!   $��Center=�6/   $��Center=�6L   $��60��6s   �� 5      $��5q�6   
���   �$��10q�6=   $	��200��6I   ._�5      �� -   5        $��liczba2��5   ,   $��liczba x��6   $��40(�6;   $ 10q�6I   $ Center=�6V   5      �� 5      $��=��6   $��80(�6!   $��Center=�6/   $��Center=�6L   �� 5      $��5q�6   
���   �$��10q�6=   $	��200��6I   ._�5      �� -   5        $��wynik��5      $��40(�6)   $ 10q�67   5      5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��Center=�6;   .+�5       �� $��5q�6   
���   �$��10,10,90,10q�6=   $	��200��6R   ._�5!      �� -   5        $��Losuj��5!      $��40(�6)   67   5"      	� 5#      -   5        $��+��5#      $��80(�6&    	� 	GroupName$
 znak��64   $	��100��6E   6Q   	� 5$      -   5        $��-��5$      $��80(�6&   $
 znak��64   $	��100��6E   6Q   	� 5%      -	   5        $��*��5%      $��80(�6&   $
 znak��64   $	��100��6E   6Q   	� 5&      -
   5        $��/��5&      $��80(�6&   $
 znak��64   $	��100��6E   6Q   5'      �� 5(   
   -   5        $��obraz��5(      $��grafika/pytanie.png��6   $	��120��6:   $��3��6F   5)      5*      