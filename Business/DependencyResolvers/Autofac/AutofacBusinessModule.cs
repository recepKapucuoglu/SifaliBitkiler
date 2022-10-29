using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule:Module
	{
		protected override void Load(ContainerBuilder builder)
		{
            builder.RegisterType<BitkiManager>().As<IBitkiService>().SingleInstance();
            builder.RegisterType<EfBitkiDal>().As<IBitkiDal>().SingleInstance();




            builder.RegisterType<SikayetEtkiBitkiManager>().As<ISikayetEtkiBitkiService>().SingleInstance();
            builder.RegisterType<EfSikayetEtkiBitkiDal>().As<ISikayetEtkiBitkiDal>().SingleInstance();


            builder.RegisterType<SikayetEtkiManager>().As<ISikayetEtkiService>().SingleInstance();
            builder.RegisterType<EfSikayetEtkiDal>().As<ISikayetEtkiDal>().SingleInstance();

            //builder.RegisterType<OptionManager>().As<IOptionService>().SingleInstance();
            //builder.RegisterType<EfOptionDal>().As<IOptionDal>().SingleInstance();


            //builder.RegisterType<UserExamManager>().As<IUserExamService>().SingleInstance();
            //builder.RegisterType<EfUserExamDal>().As<IUserExamDal>().SingleInstance();




        }
	}
}
