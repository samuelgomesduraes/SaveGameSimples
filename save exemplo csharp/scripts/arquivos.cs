using Godot;
using System;

public class arquivos : Node2D
{
dados dado;
Label quantidade;
	public override void _Ready()
	{
		dado=GetNode<dados>("/root/Dados");//aqui estou passando script globa la do autoload
		quantidade=GetNode<Label>("quantidade");
	}


private void saver(string datatosave){
File file=new File();
file.Open("user://datafile.txt",File.ModeFlags.Write);
file.StoreString(datatosave);
file.Close();
}

private string loader(){
 File file=new File();
 file.Open("user://datafile.txt",File.ModeFlags.Read);
var textinthefile=file.GetAsText();


return textinthefile;
}











	public override void _Process(float delta){
		quantidade.Text="trigo: "+dado.trigo.ToString();
	}




	private void _on_salvar_pressed(){
		var trigo=dado.trigo.ToString();
		saver(trigo);
	}
	private void _on_carregar_pressed(){
		dado.trigo=loader().ToInt();
	}
	private void _on_aumentar_pressed(){
		dado.trigo+=1;
	}
	private void _on_diminuir_pressed(){
		 dado.trigo-=1;
	}

}
