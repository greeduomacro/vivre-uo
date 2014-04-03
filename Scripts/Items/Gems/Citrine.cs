using System;
using Server;

namespace Server.Items
{
    public class Citrine : BaseGem
    {
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public Citrine() : this( 1 )
		{
		}

		[Constructable]
		public Citrine( int amount ) : base( 0xF15 )
		{
			Stackable = true;
			Amount = amount;
            Gems = GemType.Citrine;
		}

		public Citrine( Serial serial ) : base( serial )
		{
		}

		

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
            if (version < 1)
                Gems = GemType.Citrine;
		}
	}
}