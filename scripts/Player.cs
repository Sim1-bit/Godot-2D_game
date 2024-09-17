using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public const float Speed = 100.0f;

	public override void _PhysicsProcess(double delta)
	{
		// Resetto la velocità
		Vector2 velocity = Vector2.Zero;

		// Prendo l'input del giocatore
		if (Input.IsActionPressed("ui_right"))
		{
			velocity.X += 1;
		}
		if (Input.IsActionPressed("ui_left"))
		{
			velocity.X -= 1;
		}
		if (Input.IsActionPressed("ui_down"))
		{
			velocity.Y += 1;
		}
		if (Input.IsActionPressed("ui_up"))
		{
			velocity.Y -= 1;
		}

		// Normalizzo il vettore di velocità per evitare di muoversi più velocemente in diagonale
		if (velocity != Vector2.Zero)
		{
			velocity = velocity.Normalized() * Speed;
		}

		// Muovo il personaggio
		Velocity = velocity;
		MoveAndSlide();
	}
}
